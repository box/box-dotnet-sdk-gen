using Box.Sdk.Gen;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Net.Http;

namespace Box.Sdk.Gen.Internal
{
    /// <summary>
    /// Holds parameters used for http/s request.
    /// </summary>
    class FetchOptions
    {
        /// <summary>
        /// Http/s Method as string.
        /// </summary>
        internal string? Method { get; init; }

        /// <summary>
        /// Authentication type used for the request.
        /// </summary>
        internal IAuthentication? Auth { get; init; }

        /// <summary>
        /// Body of the http/s request.
        /// </summary>
        internal SerializedData? Data { get; init; }

        /// <summary>
        /// A stream containing the contents of a file.
        /// </summary>
        internal Stream? FileStream { get; init; }

        /// <summary>
        /// Headers of the http/s request.
        /// </summary>
        internal IReadOnlyDictionary<string, string> Headers { get; init; } = new ReadOnlyDictionary<string, string>(new Dictionary<string, string>());

        /// <summary>
        /// Content type header of the http/s request.
        /// </summary>
        internal string? ContentType { get; init; }

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
        internal NetworkSession NetworkSession { get; }

        /// <summary>
        /// Query parameters.
        /// </summary>
        internal IReadOnlyDictionary<string, string>? Parameters { get; init; }

        /// <summary>
        /// List of multipart items for the request.
        /// </summary>
        internal IReadOnlyCollection<MultipartItem>? MultipartData { get; init; }

        /// <summary>
        /// Format of the response e.g. "binary" in case of stream response.
        /// </summary>
        internal string? ResponseFormat { get; init; }

        /// <summary>
        /// Token used for request cancellation.
        /// </summary>
        internal System.Threading.CancellationToken? CancellationToken { get; init; }


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
        internal FetchOptions(NetworkSession networkSession)
        {
            NetworkSession = networkSession;
        }
    }
}
