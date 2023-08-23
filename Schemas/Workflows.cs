using System.IO;
using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Text.Json;

namespace Box.Schemas {
    public class Workflows {
        [JsonPropertyName("limit")]
        public long? Limit { get; }

        [JsonPropertyName("next_marker")]
        public long? NextMarker { get; }

        [JsonPropertyName("prev_marker")]
        public long? PrevMarker { get; }

        [JsonPropertyName("entries")]
        public IReadOnlyList<Workflow> Entries { get; }

        public Workflows(long? limit, long? nextMarker, long? prevMarker, IReadOnlyList<Workflow> entries) {
            Limit = limit;
            NextMarker = nextMarker;
            PrevMarker = prevMarker;
            Entries = entries;
        }
    }
}