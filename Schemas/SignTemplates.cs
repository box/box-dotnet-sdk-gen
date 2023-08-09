using System.IO;
using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;

namespace Box.Schemas {
    public class SignTemplates {
        [JsonPropertyName("limit")]
        public int? Limit { get; }

        [JsonPropertyName("next_marker")]
        public string NextMarker { get; }

        [JsonPropertyName("prev_marker")]
        public string PrevMarker { get; }

        public SignTemplates(int? limit, string nextMarker, string prevMarker) {
            Limit = limit;
            NextMarker = nextMarker;
            PrevMarker = prevMarker;
        }
    }
}