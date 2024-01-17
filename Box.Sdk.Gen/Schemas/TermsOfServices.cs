using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Text.Json;

namespace Box.Sdk.Gen.Schemas {
    public class TermsOfServices {
        /// <summary>
        /// The total number of objects.
        /// </summary>
        [JsonPropertyName("total_count")]
        public long? TotalCount { get; set; } = default;

        /// <summary>
        /// A list of terms of service objects
        /// </summary>
        [JsonPropertyName("entries")]
        public IReadOnlyList<TermsOfService>? Entries { get; set; } = default;

        public TermsOfServices() {
            
        }
    }
}