using System.IO;
using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;

namespace Box.Schemas {
    public class RealtimeServers {
        [JsonPropertyName("chunk_size")]
        public int? ChunkSize { get; }

        [JsonPropertyName("entries")]
        public IReadOnlyList<RealtimeServer> Entries { get; }

        public RealtimeServers(int? chunkSize, IReadOnlyList<RealtimeServer> entries) {
            ChunkSize = chunkSize;
            Entries = entries;
        }
    }
}