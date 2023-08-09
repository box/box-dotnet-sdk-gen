using System.IO;
using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;

namespace Box.Schemas {
    public class RealtimeServer {
        [JsonPropertyName("type")]
        public string Type { get; }

        [JsonPropertyName("url")]
        public string Url { get; }

        [JsonPropertyName("ttl")]
        public int? Ttl { get; }

        [JsonPropertyName("max_retries")]
        public int? MaxRetries { get; }

        [JsonPropertyName("retry_timeout")]
        public int? RetryTimeout { get; }

        public RealtimeServer(string type, string url, int? ttl, int? maxRetries, int? retryTimeout) {
            Type = type;
            Url = url;
            Ttl = ttl;
            MaxRetries = maxRetries;
            RetryTimeout = retryTimeout;
        }
    }
}