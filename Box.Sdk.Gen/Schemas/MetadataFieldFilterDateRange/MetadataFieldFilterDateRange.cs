using Unions;
using System.Text.Json.Serialization;

namespace Box.Sdk.Gen.Schemas {
    public class MetadataFieldFilterDateRange {
        /// <summary>
        /// Specifies the (inclusive) upper bound for the metadata field
        /// value. The value of a field must be lower than (`lt`) or
        /// equal to this value for the search query to match this
        /// template.
        /// </summary>
        [JsonPropertyName("lt")]
        public System.DateTimeOffset? Lt { get; set; } = default;

        /// <summary>
        /// Specifies the (inclusive) lower bound for the metadata field
        /// value. The value of a field must be greater than (`gt`) or
        /// equal to this value for the search query to match this
        /// template.
        /// </summary>
        [JsonPropertyName("gt")]
        public System.DateTimeOffset? Gt { get; set; } = default;

        public MetadataFieldFilterDateRange() {
            
        }
    }
}