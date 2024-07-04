using System.Collections.Generic;
using System.Text.Json.Serialization;
using Box.Sdk.Gen.Internal;

namespace Box.Sdk.Gen
{
    public class ResponseInfo
    {
        public int StatusCode { get; }

        public IReadOnlyDictionary<string, string> Headers { get; }

        public SerializedData? Body { get; }

        public string? RawBody { get; }

        public string? Code { get; }

        public Dictionary<string, object>? ContextInfo { get; }

        public string? RequestId { get; }

        public string? HelpUrl { get; }

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
        public string? Code { get; init; }

        [JsonPropertyName("context_info")]
        public Dictionary<string, object>? ContextInfo { get; init; }

        [JsonPropertyName("request_id")]
        public string? RequestId { get; init; }

        [JsonPropertyName("help_url")]
        public string? HelpUrl { get; init; }

        public BoxApiExceptionDetails() { }
    }

}