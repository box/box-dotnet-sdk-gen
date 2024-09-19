using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading;
using System.Threading.Tasks;

namespace Box.Sdk.Gen.Internal
{
    static class ContentTypes
    {
        internal const string FormUrlEncoded = "application/x-www-form-urlencoded";
        internal const string MultipartFormData = "multipart/form-data";
        internal const string OctetStream = "application/octet-stream";
    }

    /// <summary>
    /// Static HttpClient.
    /// </summary>
    static class HttpClientAdapter
    {
        static IHttpClientFactory _clientFactory;

        static HttpClientAdapter()
        {
            var serviceCollection = new ServiceCollection();

            serviceCollection.AddHttpClient();

            var httpClientFactory = serviceCollection.BuildServiceProvider().GetService<IHttpClientFactory>();
            if (httpClientFactory == null)
            {
                throw new BoxSdkException("Unable to create HttpClient. Cannot get an IHttpClientFactory instance from a ServiceProvider.");
            }
            _clientFactory = httpClientFactory;
        }

        /// <summary>
        /// Executes http/s request.
        /// </summary>
        /// <param name="options">Request options of a request.</param>
        /// <returns>A http/s Response as a FetchResponse.</returns>
        internal static async Task<FetchResponse> FetchAsync(FetchOptions options)
        {
            var client = _clientFactory.CreateClient();

            var networkSession = options.NetworkSession ?? new NetworkSession();
            var attempt = 1;
            var cancellationToken = options.CancellationToken ?? default(System.Threading.CancellationToken);

            bool isStreamResponse = options.ResponseFormat == "binary";

            Stream? seekableStream = null;
            if (options.FileStream != null && options.ContentType == ContentTypes.OctetStream)
            {
                // buffer the stream in memory in case we cannot rewind it
                seekableStream = options.FileStream.CanSeek ? options.FileStream : await ToMemoryStreamAsync(options.FileStream).ConfigureAwait(false);
            }

            while (true)
            {
                var request = await BuildHttpRequest(options, seekableStream).ConfigureAwait(false);
                var result = await ExecuteRequest(client, request, isStreamResponse, cancellationToken).ConfigureAwait(false);

                if (result.IsSuccess)
                {
                    var response = result.Value!;

                    var statusCode = (int)response.StatusCode;
                    var isRetryAfterPresent = response.Headers.Contains("retry-after");
                    var isRetryAfterWithAcceptedPresent = isRetryAfterPresent && statusCode == 202;

                    if (response.IsSuccessStatusCode && !isRetryAfterWithAcceptedPresent)
                    {
                        seekableStream?.Dispose();
                        return isStreamResponse ?
                            new FetchResponse { Status = statusCode, Content = await response.Content.ReadAsStreamAsync(cancellationToken).ConfigureAwait(false) } :
                            new FetchResponse { Status = statusCode, Data = JsonUtils.JsonToSerializedData(await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false)) };
                    }

                    if (attempt >= networkSession.RetryAttempts)
                    {
                        seekableStream?.Dispose();
                        throw new BoxSdkException($"Max retry attempts excedeed.", DateTimeOffset.UtcNow);
                    }

                    if (statusCode == 401)
                    {
                        if (options.Auth != null)
                        {
                            await options.Auth.RefreshTokenAsync(networkSession).ConfigureAwait(false);
                        }
                    }
                    else if (statusCode == 429 || statusCode >= 500 || isRetryAfterWithAcceptedPresent)
                    {
                        var retryTimeout = isRetryAfterPresent ?
                          int.Parse(response.Headers.GetValues("retry-after").First()) :
                          networkSession.RetryStrategy.GetRetryTimeout(attempt);

                        await System.Threading.Tasks.Task.Delay(TimeSpan.FromSeconds(retryTimeout)).ConfigureAwait(false);
                    }
                    else
                    {
                        seekableStream?.Dispose();
                        throw await BuildApiException(request, response, options, statusCode, cancellationToken).ConfigureAwait(false);
                    }

                    response?.Dispose();
                }
                else
                {
                    if (attempt >= networkSession.RetryAttempts)
                    {
                        seekableStream?.Dispose();
                        throw new BoxSdkException($"Network error. Max retry attempts excedeed. {result.Exception?.ToString()}", DateTimeOffset.UtcNow);
                    }

                    var retryTimeout = networkSession.RetryStrategy.GetRetryTimeout(attempt);
                    await System.Threading.Tasks.Task.Delay(TimeSpan.FromSeconds(retryTimeout)).ConfigureAwait(false);

                    // reauth in case of terminated connection by the peer
                    if (options.Auth != null)
                    {
                        await options.Auth.RefreshTokenAsync(networkSession).ConfigureAwait(false);
                    }
                }

                attempt++;
            }

        }

        private static async Task<Exception> BuildApiException(HttpRequestMessage request, HttpResponseMessage? response, FetchOptions options,
            int statusCode, System.Threading.CancellationToken cancellationToken)
        {
            string responseContent;
            Dictionary<string, string> responseHeaders;

            if (response != null)
            {
                responseContent = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                responseHeaders = response.Headers.Where(x => x.Value.Any()).ToDictionary(x => x.Key, x => x.Value.First());
            }
            else
            {
                responseContent = "empty";
                responseHeaders = new Dictionary<string, string>();
            }

            response?.Dispose();

            var requestHeaders = request.Headers
                .Where(x => x.Value.Any())
                .ToDictionary(x => x.Key, x => x.Value.First());

            var requestInfo = new RequestInfo(request.Method.ToString(), request.RequestUri?.ToString(), options.Parameters, requestHeaders);

            var responseAsSerializedData = JsonUtils.JsonToSerializedData(responseContent);
            var errorDetails = SimpleJsonSerializer.DeserializeWithoutRawJson<BoxApiExceptionDetails>(responseAsSerializedData);

            var responseInfo = new ResponseInfo(statusCode, responseHeaders, responseAsSerializedData, responseContent, errorDetails.Code, errorDetails.ContextInfo,
                errorDetails.RequestId, errorDetails.HelpUrl);

            return new BoxApiException(responseContent, DateTimeOffset.UtcNow, requestInfo, responseInfo);
        }

        private static async Task<HttpRequestMessage> BuildHttpRequest(FetchOptions options, Stream? stream)
        {
            var httpRequest = new HttpRequestMessage
            {
                Method = options._httpMethod,
                RequestUri = HttpUtils.BuildUri(options.Url, options.Parameters),
                Content = BuildHttpContent(options, stream)
            };

            if (options.NetworkSession != null)
            {
                foreach (var header in options.NetworkSession.AdditionalHeaders)
                {
                    httpRequest.Headers.Add(header.Key, header.Value);
                }
            }

            foreach (var header in options.Headers)
            {
                //TODO make it more generic
                if (header.Key == "content-range")
                {
                    var headValue = header.Value;
                    httpRequest.Content!.Headers.Add(header.Key, headValue);
                }
                else
                {
                    httpRequest.Headers.Add(header.Key, header.Value);
                }
            }

            if (options.ContentType != null && httpRequest.Content is StringContent)
            {
                httpRequest.Content!.Headers.ContentType = new MediaTypeHeaderValue(options.ContentType);
            }

            foreach (var keyValuePair in SdkConsts.AnalyticsHeaders)
            {
                httpRequest.Headers.Add(keyValuePair.Key, keyValuePair.Value);
            }

            if (options.Auth != null)
            {
                var authHeaderValue = await options.Auth.RetrieveAuthorizationHeaderAsync(options.NetworkSession).ConfigureAwait(false);
                httpRequest.Headers.Add("Authorization", authHeaderValue);
            }

            return httpRequest;
        }

        private static async Task<Result<HttpResponseMessage>> ExecuteRequest(HttpClient client, HttpRequestMessage httpRequestMessage, bool isStreamResponse,
           CancellationToken cancellationToken)
        {
            try
            {
                HttpCompletionOption completionOption = isStreamResponse ?
                    HttpCompletionOption.ResponseHeadersRead :
                    HttpCompletionOption.ResponseContentRead;

                var response = await client.SendAsync(httpRequestMessage, completionOption, cancellationToken).ConfigureAwait(false);
                return Result<HttpResponseMessage>.Ok(response);
            }
            catch (Exception ex)
            {
                return Result<HttpResponseMessage>.Fail(ex);
            }
        }

        private static HttpContent? BuildHttpContent(FetchOptions options, Stream? stream)
        {
            HttpContent? httpContent;

            if (options.ContentType == ContentTypes.MultipartFormData)
            {
                var multipartContent = new MultipartFormDataContent();

                if (options.MultipartData == null)
                {
                    throw new BoxSdkException("Could not upload file. MultipartData on FetchOptions is null");
                }

                foreach (var part in options.MultipartData)
                {
                    HttpContent partContent = part.FileStream != null ?
                        new ReusableContent(part.FileStream) :
                        part.Data != null ?
                            new StringContent(JsonUtils.SdToJson(part.Data)) :
                            throw new BoxSdkException($"HttpContent for MultipartData {part} not found");

                    // for avatar upload
                    if (part.ContentType != null && part.FileName != null)
                    {
                        partContent.Headers.ContentType = new MediaTypeHeaderValue(part.ContentType);
                        partContent.Headers.ContentDisposition = new ContentDispositionHeaderValue("form-data")
                        {
                            Name = "pic",
                            FileName = part.FileName
                        };
                    }

                    if (part.FileStream != null)
                    {
                        //TODO workaround for empty part.FileName
                        multipartContent.Add(partContent, part.PartName, "file");
                    }
                    else
                    {
                        multipartContent.Add(partContent, part.PartName);
                    }
                }

                httpContent = multipartContent;
            }
            else if (options.ContentType == ContentTypes.FormUrlEncoded && options.Data != null)
            {
                var deserialized = SimpleJsonSerializer.DeserializeWithoutRawJson<Dictionary<string, string>>(options.Data);
                httpContent = new FormUrlEncodedContent(deserialized);
            }
            else if (options.ContentType == ContentTypes.OctetStream && stream != null)
            {
                httpContent = new ReusableContent(stream);
            }
            else
            {
                httpContent = options.Data != null ? new StringContent(JsonUtils.SdToJson(options.Data)) : default;
            }

            return httpContent;
        }

        private static async Task<MemoryStream> ToMemoryStreamAsync(Stream inputStream)
        {
            var memoryStream = new MemoryStream();
            await inputStream.CopyToAsync(memoryStream).ConfigureAwait(false);
            memoryStream.Position = 0;
            return memoryStream;
        }
    }
}