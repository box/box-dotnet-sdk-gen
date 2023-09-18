using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;

namespace Box.Schemas {
    public class TermsOfServiceUserStatuses {
        /// <summary>
        /// The total number of objects.
        /// </summary>
        [JsonPropertyName("total_count")]
        public long? TotalCount { get; set; } = default;

        /// <summary>
        /// A list of terms of service user statuses
        /// </summary>
        [JsonPropertyName("entries")]
        public IReadOnlyList<TermsOfServiceUserStatus>? Entries { get; set; } = default;

        public TermsOfServiceUserStatuses() {
            
        }
    }
}