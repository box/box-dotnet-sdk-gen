using System.IO;
using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;

namespace Box.Schemas {
    public class ClientError {
        [JsonPropertyName("type")]
        public ClientErrorTypeField Type { get; }

        [JsonPropertyName("status")]
        public int? Status { get; }

        [JsonPropertyName("code")]
        public ClientErrorCodeField Code { get; }

        [JsonPropertyName("message")]
        public string Message { get; }

        [JsonPropertyName("context_info")]
        public ClientErrorContextInfoField ContextInfo { get; }

        [JsonPropertyName("help_url")]
        public string HelpUrl { get; }

        [JsonPropertyName("request_id")]
        public string RequestId { get; }

        public ClientError(ClientErrorTypeField type, int? status, ClientErrorCodeField code, string message, ClientErrorContextInfoField contextInfo, string helpUrl, string requestId) {
            Type = type;
            Status = status;
            Code = code;
            Message = message;
            ContextInfo = contextInfo;
            HelpUrl = helpUrl;
            RequestId = requestId;
        }
    }
}