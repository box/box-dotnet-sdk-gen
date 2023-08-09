using System.IO;
using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Text.Json;

namespace Box.Schemas {
    public class SignRequests {
        [JsonPropertyName("limit")]
        public int? Limit { get; }

        [JsonPropertyName("next_marker")]
        public int? NextMarker { get; }

        [JsonPropertyName("prev_marker")]
        public int? PrevMarker { get; }

        [JsonPropertyName("entries")]
        public IReadOnlyList<SignRequest> Entries { get; }

        public SignRequests(int? limit, int? nextMarker, int? prevMarker, IReadOnlyList<SignRequest> entries) {
            Limit = limit;
            NextMarker = nextMarker;
            PrevMarker = prevMarker;
            Entries = entries;
        }
    }
}