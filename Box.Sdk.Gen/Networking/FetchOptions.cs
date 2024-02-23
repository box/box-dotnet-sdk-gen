using Box.Sdk.Gen;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Net.Http;
using Serialization.Json;

namespace Fetch
{
    /// <summary>
    /// Holds parameters used for http/s request.
    /// </summary>
    public class FetchOptions
    {
        /// <summary>
        /// Http/s Method as string.
        /// </summary>
        public string? Method { get; set; }

        /// <summary>
        /// Authentication type used for the request.
        /// </summary>
        public IAuthentication? Auth { get; set; }

        /// <summary>
        /// Body of the http/s request.
        /// </summary>
        public SerializedData? Data { get; set; }

        /// <summary>
        /// A stream containing the contents of a file.
        /// </summary>
        public Stream? FileStream { get; set; }

        /// <summary>
        /// Headers of the http/s request.
        /// </summary>
        public IReadOnlyDictionary<string, string> Headers { get; set; }

        /// <summary>
        /// Content type header of the http/s request.
        /// </summary>
        public string? ContentType { get; set; }

        /// <summary>
        /// HttpMethod string mapping to the .NET HttpMethod class.
        /// </summary>
        internal HttpMethod _httpMethod
        {
            get
            {
                httpMethodsMap.TryGetValue(Method ?? throw new ArgumentException($"Provided http method {Method} is not supported."), out var tempMethod);
                return tempMethod!;
            }
        }

        /// <summary>
        /// Network session for the request.
        /// </summary>
        //TODO implement usage.
        public NetworkSession? NetworkSession { get; set; }

        /// <summary>
        /// Query parameters.
        /// </summary>
        public IReadOnlyDictionary<string, string>? Parameters { get; set; }

        /// <summary>
        /// List of multipart items for the request.
        /// </summary>
        public IReadOnlyCollection<MultipartItem>? MultipartData { get; set; }

        /// <summary>
        /// Format of the response e.g. "binary" in case of stream response.
        /// </summary>
        public string? ResponseFormat { get; set; }

        /// <summary>
        /// Token used for request cancellation.
        /// </summary>
        public System.Threading.CancellationToken? CancellationToken { get; set; }


        private static Dictionary<string, HttpMethod> httpMethodsMap = new Dictionary<string, HttpMethod>() {
            { "GET", HttpMethod.Get },
            { "POST", HttpMethod.Post },
            { "PUT", HttpMethod.Put },
            { "PATCH", HttpMethod.Patch },
            { "DELETE", HttpMethod.Delete },
            { "OPTIONS", HttpMethod.Options },
            { "HEAD", HttpMethod.Head },
            { "TRACE", HttpMethod.Trace },
        };

        /// <summary>
        /// Creates FetchOptions from the parameters.
        /// </summary>
        /// <param name="method"></param>
        /// <param name="data"></param>
        /// <param name="fileStream"></param>
        /// <param name="auth"></param>
        /// <param name="headers"></param>
        /// <param name="contentType"></param>
        public FetchOptions(string? method = null, SerializedData? data = null, Stream? fileStream = null, IAuthentication? auth = null, IReadOnlyDictionary<string, string>? headers = null, string? contentType = null, NetworkSession? networkSession = null, IReadOnlyDictionary<string, string>? parameters = null, IReadOnlyCollection<MultipartItem>? multipartData = null, string? responseFormat = null, System.Threading.CancellationToken? cancellationToken = null)
        {
            Method = method;
            Auth = auth;
            Data = data;
            FileStream = fileStream;
            Headers = headers ?? new ReadOnlyDictionary<string, string>(new Dictionary<string, string>());
            ContentType = contentType;
            NetworkSession = networkSession;
            Parameters = parameters;
            MultipartData = multipartData;
            ResponseFormat = responseFormat;
            CancellationToken = cancellationToken;
        }
    }
}
