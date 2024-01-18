using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Text.Json;

namespace Box.Sdk.Gen.Schemas {
    public class RealtimeServers {
        /// <summary>
        /// The number of items in this response.
        /// </summary>
        [JsonPropertyName("chunk_size")]
        public long? ChunkSize { get; set; } = default;

        /// <summary>
        /// A list of real-time servers
        /// </summary>
        [JsonPropertyName("entries")]
        public IReadOnlyList<RealtimeServer>? Entries { get; set; } = default;

        public RealtimeServers() {
            
        }
    }
}