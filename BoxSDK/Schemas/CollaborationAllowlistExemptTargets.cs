using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Text.Json;

namespace Box.Schemas {
    public class CollaborationAllowlistExemptTargets {
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

        /// <summary>
        /// The marker for the start of the previous page of results.
        /// </summary>
        [JsonPropertyName("prev_marker")]
        public string? PrevMarker { get; set; } = default;

        /// <summary>
        /// A list of users exempt from any of the restrictions
        /// imposed by the list of allowed collaboration domains
        /// for this enterprise.
        /// </summary>
        [JsonPropertyName("entries")]
        public IReadOnlyList<CollaborationAllowlistExemptTarget>? Entries { get; set; } = default;

        public CollaborationAllowlistExemptTargets() {
            
        }
    }
}