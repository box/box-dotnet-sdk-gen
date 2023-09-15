using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Text.Json;

namespace Box.Schemas {
    public class MetadataFieldFilterFloatRangeMapValue {
        /// <summary>
        /// Specifies the (inclusive) upper bound for the metadata field
        /// value. The value of a field must be lower than (`lt`) or
        /// equal to this value for the search query to match this
        /// template.
        /// </summary>
        [JsonPropertyName("lt")]
        public int? Lt { get; set; } = default;

        /// <summary>
        /// Specifies the (inclusive) lower bound for the metadata field
        /// value. The value of a field must be greater than (`gt`) or
        /// equal to this value for the search query to match this
        /// template.
        /// </summary>
        [JsonPropertyName("gt")]
        public int? Gt { get; set; } = default;

        public MetadataFieldFilterFloatRangeMapValue() {
            
        }
    }
}