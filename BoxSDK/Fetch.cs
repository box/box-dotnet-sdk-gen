using Box;
using Microsoft.Extensions.DependencyInjection;
using Serializer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Web;

namespace Fetch
{
    static class ContentTypes
    {
        public const string FormUrlEncoded = "application/x-www-form-urlencoded";
        public const string MultipartFormData = "multipart/form-data";
    }

    /// <summary>
    /// Static HttpClient.
    /// </summary>
    public static class HttpClientAdapter
    {
        static IHttpClientFactory _clientFactory;

        static HttpClientAdapter()
        {
            var serviceProvider = new ServiceCollection().AddHttpClient().BuildServiceProvider();
            var httpClientFactory = serviceProvider.GetService<IHttpClientFactory>();
            if (httpClientFactory == null)
            {
                throw new ArgumentException("Unable to create HttpClient. Cannot get an IHttpClientFactory instance from a ServiceProvider.");
            }
            _clientFactory = httpClientFactory;
        }

        /// <summary>
        /// Executes http/s request.
        /// </summary>
        /// <param name="resource">Target url of a request.</param>
        /// <param name="options">Request options of a request.</param>
        /// <returns>A http/s Response as a FetchResponse.</returns>
        public static async Task<FetchResponse> FetchAsync(string resource, FetchOptions options)
        {
            var client = _clientFactory.CreateClient();

            var networkSession = options.NetworkSession ?? new NetworkSession();
            var attempt = 1;

            bool isStreamResponse = options.ResponseFormat == "binary";
            while (true)
            {
                var request = await BuildHttpRequest(resource, options).ConfigureAwait(false);
                var response = await ExecuteRequest(client, request).ConfigureAwait(false);

                var statusCode = (int)response.StatusCode;

                if (response.IsSuccessStatusCode)
                {
                    return isStreamResponse ?
                        new FetchResponse { Status = statusCode, Content = await response.Content.ReadAsStreamAsync().ConfigureAwait(false) } :
                        new FetchResponse { Status = statusCode, Text = await response.Content.ReadAsStringAsync().ConfigureAwait(false) };
                }

                if (attempt >= networkSession.RetryAttempts)
                {
                    throw await BuildApiException(response, statusCode, "Max retry attempts excedeed.").ConfigureAwait(false);
                }

                if (statusCode == 401)
                {
                    if (options.Auth != null)
                    {
                        await options.Auth.RefreshTokenAsync().ConfigureAwait(false);
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
                    throw await BuildApiException(response, statusCode).ConfigureAwait(false);
                }

                response?.Dispose();
                attempt++;
            }

        }

        private static async Task<Exception> BuildApiException(HttpResponseMessage? response, int statusCode, string? message = null)
        {
            var responseContent = response != null ? await response.Content.ReadAsStringAsync().ConfigureAwait(false) : "empty";
            response?.Dispose();
            return message != null ?
                new ApiException(statusCode, responseContent, ApiException.BuildApiExceptionMessage(statusCode, responseContent, message)) :
                new ApiException(statusCode, responseContent);
        }

        private static async Task<HttpRequestMessage> BuildHttpRequest(string resource, FetchOptions options)
        {
            var httpRequest = new HttpRequestMessage
            {
                Method = options._httpMethod,
                RequestUri = BuildUri(resource, options),
                Content = BuildHttpContent(options)
            };

            foreach (var header in options.Headers)
            {
                httpRequest.Headers.Add(header.Key, header.Value);
            }

            foreach (var keyValuePair in SdkConsts.AnalyticsHeaders)
            {
                httpRequest.Headers.Add(keyValuePair.Key, keyValuePair.Value);
            }

            if (options.Auth != null)
            {
                var token = await options.Auth.RetrieveTokenAsync().ConfigureAwait(false);
                httpRequest.Headers.Add("Authorization", $"Bearer {token.AccessTokenField}");
            }

            return httpRequest;
        }

        private static async Task<HttpResponseMessage> ExecuteRequest(HttpClient client, HttpRequestMessage httpRequestMessage)
        {
            try
            {
                return await client.SendAsync(httpRequestMessage).ConfigureAwait(false);
            }
            catch
            {
                throw;
            }
        }

        private static Uri BuildUri(string resource, FetchOptions options)
        {
            return options.Parameters?.Count > 0 ?
                new Uri(string.Join("?", resource, string.Join('&',
                    options.Parameters.Select(q => $"{HttpUtility.UrlEncode(q.Key)}={HttpUtility.UrlEncode(q.Value)}")))) :
                new Uri(resource);
        }

        private static HttpContent? BuildHttpContent(FetchOptions options)
        {
            HttpContent? httpContent;

            if (options.ContentType == ContentTypes.MultipartFormData)
            {
                var multipartContent = new MultipartFormDataContent();

                if (options.MultipartData == null)
                {
                    throw new ArgumentException("Could not upload file. MultipartData on FetchOptions is null");
                }

                foreach (var part in options.MultipartData)
                {
                    HttpContent partContent = part.FileStream != null ?
                        new StreamContent(part.FileStream) :
                        part.Body != null ?
                            new StringContent(part.Body) :
                            throw new ArgumentException($"HttpContent for MultipartData {part} not found");

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
            else if (options.ContentType == ContentTypes.FormUrlEncoded && options.Body != null)
            {
                var deserialized = SimpleJsonSerializer.Deserialize<Dictionary<string, string>>(options.Body);
                httpContent = new FormUrlEncodedContent(deserialized);
            }
            else
            {
                httpContent = options.Body != null ? new StringContent(options.Body) : default;
            }

            return httpContent;
        }
    }
}