using System.IO;
using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Text.Json;

namespace Box.Schemas {
    public class Events {
        [JsonPropertyName("chunk_size")]
        public int? ChunkSize { get; }

        [JsonPropertyName("next_stream_position")]
        public string NextStreamPosition { get; }

        [JsonPropertyName("entries")]
        public IReadOnlyList<Event> Entries { get; }

        public Events(int? chunkSize, string nextStreamPosition, IReadOnlyList<Event> entries) {
            ChunkSize = chunkSize;
            NextStreamPosition = nextStreamPosition;
            Entries = entries;
        }
    }
}