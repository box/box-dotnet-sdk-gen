using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Box.Sdk.Gen
{
    public class RequestInfo
    {
        public string Method { get; }

        public string Url { get; }

        public IReadOnlyDictionary<string, string> QueryParams { get; }

        public IReadOnlyDictionary<string, string> Headers { get; }

        public string? Body { get; init; }

        public RequestInfo(string method, string? url, IReadOnlyDictionary<string, string>? queryParams, IReadOnlyDictionary<string, string> headers)
        {
            Method = method;
            Url = url ?? "";
            QueryParams = queryParams ?? new ReadOnlyDictionary<string, string>(new Dictionary<string, string>());
            Headers = headers;
        }
    }
}