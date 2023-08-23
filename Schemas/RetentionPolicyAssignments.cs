using System.IO;
using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;

namespace Box.Schemas {
    public class RetentionPolicyAssignments {
        [JsonPropertyName("entries")]
        public IReadOnlyList<RetentionPolicyAssignmentBase> Entries { get; }

        [JsonPropertyName("limit")]
        public long? Limit { get; }

        [JsonPropertyName("next_marker")]
        public string NextMarker { get; }

        public RetentionPolicyAssignments(IReadOnlyList<RetentionPolicyAssignmentBase> entries, long? limit, string nextMarker) {
            Entries = entries;
            Limit = limit;
            NextMarker = nextMarker;
        }
    }
}