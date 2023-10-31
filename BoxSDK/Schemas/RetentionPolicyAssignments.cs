using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Text.Json;

namespace Box.Schemas {
    public class RetentionPolicyAssignments {
        /// <summary>
        /// A list of retention policy assignments
        /// </summary>
        [JsonPropertyName("entries")]
        public IReadOnlyList<RetentionPolicyAssignment>? Entries { get; set; } = default;

        /// <summary>
        /// The limit that was used for these entries. This will be the same as the
        /// `limit` query parameter unless that value exceeded the maximum value
        /// allowed. The maximum value varies by API.
        /// </summary>
        [JsonPropertyName("limit")]
        public long? Limit { get; set; } = default;

        /// <summary>
        /// The marker for the start of the next page of results.
        /// </summary>
        [JsonPropertyName("next_marker")]
        public string? NextMarker { get; set; } = default;

        public RetentionPolicyAssignments() {
            
        }
    }
}