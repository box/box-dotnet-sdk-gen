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
        public int? Limit { get; }

        [JsonPropertyName("next_marker")]
        public int? NextMarker { get; }

        [JsonPropertyName("prev_marker")]
        public int? PrevMarker { get; }

        [JsonPropertyName("entries")]
        public IReadOnlyList<Workflow> Entries { get; }

        public Workflows(int? limit, int? nextMarker, int? prevMarker, IReadOnlyList<Workflow> entries) {
            Limit = limit;
            NextMarker = nextMarker;
            PrevMarker = prevMarker;
            Entries = entries;
        }
    }
}