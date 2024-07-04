using Box.Sdk.Gen;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
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
            var serviceProvider = new ServiceCollection().AddHttpClient().BuildServiceProvider();
            var httpClientFactory = serviceProvider.GetService<IHttpClientFactory>();
            if (httpClientFactory == null)
            {
                throw new BoxSdkException("Unable to create HttpClient. Cannot get an IHttpClientFactory instance from a ServiceProvider.");
            }
            _clientFactory = httpClientFactory;
        }

        /// <summary>
        /// Executes http/s request.
        /// </summary>
        /// <param name="resource">Target url of a request.</param>
        /// <param name="options">Request options of a request.</param>
        /// <returns>A http/s Response as a FetchResponse.</returns>
        internal static async Task<FetchResponse> FetchAsync(string resource, FetchOptions options)
        {
            var client = _clientFactory.CreateClient();

            var networkSession = options.NetworkSession ?? new NetworkSession();
            var attempt = 1;
            var cancellationToken = options.CancellationToken ?? default(System.Threading.CancellationToken);

            bool isStreamResponse = options.ResponseFormat == "binary";
            while (true)
            {
                var request = await BuildHttpRequest(resource, options).ConfigureAwait(false);
                var response = await ExecuteRequest(client, request, cancellationToken).ConfigureAwait(false);

                var statusCode = (int)response.StatusCode;

                if (response.IsSuccessStatusCode)
                {
                    return isStreamResponse ?
                        new FetchResponse { Status = statusCode, Content = await response.Content.ReadAsStreamAsync(cancellationToken).ConfigureAwait(false) } :
                        new FetchResponse { Status = statusCode, Data = JsonUtils.JsonToSerializedData(await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false)) };
                }

                if (attempt >= networkSession.RetryAttempts)
                {
                    throw await BuildApiException(request, response, options, statusCode, cancellationToken, "Max retry attempts excedeed.").ConfigureAwait(false);
                }

                if (statusCode == 401)
                {
                    if (options.Auth != null)
                    {
                        await options.Auth.RefreshTokenAsync(networkSession).ConfigureAwait(false);
                    }
                }
                else if (statusCode == 429 || statusCode >= 500)
                {
                    var retryTimeout = response.Headers.Contains("retry-after") ?
                      int.Parse(response.Headers.GetValues("retry-after").First()) :
                      networkSession.RetryStrategy.GetRetryTimeout(attempt);

                    await Task.Delay(TimeSpan.FromSeconds(retryTimeout)).ConfigureAwait(false);
                }
                else
                {
                    throw await BuildApiException(request, response, options, statusCode, cancellationToken).ConfigureAwait(false);
                }

                response?.Dispose();
                attempt++;
            }

        }

        private static async Task<Exception> BuildApiException(HttpRequestMessage request, HttpResponseMessage? response, FetchOptions options,
            int statusCode, System.Threading.CancellationToken cancellationToken, string? message = null)
        {
            if (message != null)
            {
                return new BoxSdkException(message, DateTimeOffset.UtcNow);
            }

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
            var errorDetails = SimpleJsonSerializer.Deserialize<BoxApiExceptionDetails>(responseAsSerializedData);

            var responseInfo = new ResponseInfo(statusCode, responseHeaders, responseAsSerializedData, responseContent, errorDetails.Code, errorDetails.ContextInfo,
                errorDetails.RequestId, errorDetails.HelpUrl);

            return new BoxApiException(responseContent, DateTimeOffset.UtcNow, requestInfo, responseInfo);
        }

        private static async Task<HttpRequestMessage> BuildHttpRequest(string resource, FetchOptions options)
        {
            var httpRequest = new HttpRequestMessage
            {
                Method = options._httpMethod,
                RequestUri = HttpUtils.BuildUri(resource, options.Parameters),
                Content = BuildHttpContent(options)
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

        private static async Task<HttpResponseMessage> ExecuteRequest(HttpClient client, HttpRequestMessage httpRequestMessage, CancellationToken cancellationToken)
        {
            try
            {
                return await client.SendAsync(httpRequestMessage, cancellationToken).ConfigureAwait(false);
            }
            catch
            {
                throw;
            }
        }

        private static HttpContent? BuildHttpContent(FetchOptions options)
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
                        new StreamContent(part.FileStream) :
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
                var deserialized = SimpleJsonSerializer.Deserialize<Dictionary<string, string>>(options.Data);
                httpContent = new FormUrlEncodedContent(deserialized);
            }
            else if (options.ContentType == ContentTypes.OctetStream)
            {
                httpContent = new StreamContent(options.FileStream);
            }
            else
            {
                httpContent = options.Data != null ? new StringContent(JsonUtils.SdToJson(options.Data)) : default;
            }

            return httpContent;
        }
    }
}