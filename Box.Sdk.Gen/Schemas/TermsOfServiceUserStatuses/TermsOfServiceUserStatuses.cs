using Box.Sdk.Gen;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Box.Sdk.Gen.Schemas;

namespace Box.Sdk.Gen.Schemas {
    public class TermsOfServiceUserStatuses {
        /// <summary>
        /// The total number of objects.
        /// </summary>
        [JsonPropertyName("total_count")]
        public long? TotalCount { get; init; }

        /// <summary>
        /// A list of terms of service user statuses
        /// </summary>
        [JsonPropertyName("entries")]
        public IReadOnlyList<TermsOfServiceUserStatus>? Entries { get; init; }

        public TermsOfServiceUserStatuses() {
            
        }
    }
}