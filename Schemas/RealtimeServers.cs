using System.IO;
using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;

namespace Box.Schemas {
    public class RealtimeServers {
        [JsonPropertyName("chunk_size")]
        public long? ChunkSize { get; }

        [JsonPropertyName("entries")]
        public IReadOnlyList<RealtimeServer> Entries { get; }

        public RealtimeServers(long? chunkSize, IReadOnlyList<RealtimeServer> entries) {
            ChunkSize = chunkSize;
            Entries = entries;
        }
    }
}