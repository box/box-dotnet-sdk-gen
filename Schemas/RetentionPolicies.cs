using System.IO;
using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;

namespace Box.Schemas {
    public class RetentionPolicies {
        [JsonPropertyName("entries")]
        public IReadOnlyList<RetentionPolicyMini> Entries { get; }

        [JsonPropertyName("limit")]
        public int? Limit { get; }

        [JsonPropertyName("next_marker")]
        public string NextMarker { get; }

        public RetentionPolicies(IReadOnlyList<RetentionPolicyMini> entries, int? limit, string nextMarker) {
            Entries = entries;
            Limit = limit;
            NextMarker = nextMarker;
        }
    }
}