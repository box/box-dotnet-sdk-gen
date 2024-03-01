using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Errors
{
    public class RequestInfo
    {
        public string Method { get; set; }

        public string Url { get; set; }

        public IReadOnlyDictionary<string, string> QueryParams { get; set; }

        public IReadOnlyDictionary<string, string> Headers { get; set; }

        public string? Body { get; set; } = default;

        public RequestInfo(string method, string? url, IReadOnlyDictionary<string, string>? queryParams, IReadOnlyDictionary<string, string> headers)
        {
            Method = method;
            Url = url ?? "";
            QueryParams = queryParams ?? new ReadOnlyDictionary<string, string>(new Dictionary<string, string>());
            Headers = headers;
        }
    }
}