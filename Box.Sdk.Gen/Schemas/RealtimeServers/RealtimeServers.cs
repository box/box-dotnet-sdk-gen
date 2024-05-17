using Unions;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Box.Sdk.Gen.Schemas;

namespace Box.Sdk.Gen.Schemas {
    public class RealtimeServers {
        /// <summary>
        /// The number of items in this response.
        /// </summary>
        [JsonPropertyName("chunk_size")]
        public long? ChunkSize { get; init; }

        /// <summary>
        /// A list of real-time servers
        /// </summary>
        [JsonPropertyName("entries")]
        public IReadOnlyList<RealtimeServer>? Entries { get; init; }

        public RealtimeServers() {
            
        }
    }
}