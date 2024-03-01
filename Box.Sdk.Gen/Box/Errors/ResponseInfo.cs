using Serialization.Json;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Errors
{
    public class ResponseInfo
    {
        public int StatusCode { get; set; }

        public IReadOnlyDictionary<string, string> Headers { get; set; }

        public SerializedData? Body { get; set; } = default;

        public string? RawBody { get; set; } = default;

        public string? Code { get; set; } = default;

        public Dictionary<string, object>? ContextInfo { get; set; } = default;

        public string? RequestId { get; set; } = default;

        public string? HelpUrl { get; set; } = default;

        public ResponseInfo(int statusCode, IReadOnlyDictionary<string, string> headers, SerializedData body, string rawBody,
            string? code, Dictionary<string, object>? contextInfo, string? requestId, string? helpUrl)
        {
            StatusCode = statusCode;
            Headers = headers;
            Body = body;
            RawBody = rawBody;
            Code = code;
            ContextInfo = contextInfo ?? new Dictionary<string, object>();
            RequestId = requestId;
            HelpUrl = helpUrl;
        }
    }

    internal class BoxApiExceptionDetails
    {
        [JsonPropertyName("code")]
        public string? Code { get; set; }

        [JsonPropertyName("context_info")]
        public Dictionary<string, object>? ContextInfo { get; set; }

        [JsonPropertyName("request_id")]
        public string? RequestId { get; set; }

        [JsonPropertyName("help_url")]
        public string? HelpUrl { get; set; }

        public BoxApiExceptionDetails() { }
    }

}