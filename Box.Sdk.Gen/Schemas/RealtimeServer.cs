using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Text.Json;

namespace Box.Sdk.Gen.Schemas {
    public class RealtimeServer {
        /// <summary>
        /// `realtime_server`
        /// </summary>
        [JsonPropertyName("type")]
        public string? Type { get; set; } = default;

        /// <summary>
        /// The URL for the server.
        /// </summary>
        [JsonPropertyName("url")]
        public string? Url { get; set; } = default;

        /// <summary>
        /// The time in minutes for which this server is available
        /// </summary>
        [JsonPropertyName("ttl")]
        public long? Ttl { get; set; } = default;

        /// <summary>
        /// The maximum number of retries this server will
        /// allow before a new long poll should be started by
        /// getting a [new list of server](#options-events).
        /// </summary>
        [JsonPropertyName("max_retries")]
        public long? MaxRetries { get; set; } = default;

        /// <summary>
        /// The maximum number of seconds without a response
        /// after which you should retry the long poll connection.
        /// 
        /// This helps to overcome network issues where the long
        /// poll looks to be working but no packages are coming
        /// through.
        /// </summary>
        [JsonPropertyName("retry_timeout")]
        public long? RetryTimeout { get; set; } = default;

        public RealtimeServer() {
            
        }
    }
}