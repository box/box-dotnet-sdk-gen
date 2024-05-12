using Unions;
using System.Text.Json.Serialization;
using Box.Sdk.Gen.Schemas;

namespace Box.Sdk.Gen.Schemas {
    public class DevicePinnersOrderField {
        /// <summary>
        /// The field that is ordered by
        /// </summary>
        [JsonPropertyName("by")]
        public DevicePinnersOrderByField? By { get; set; } = default;

        /// <summary>
        /// The direction to order by, either ascending or descending
        /// </summary>
        [JsonPropertyName("direction")]
        public DevicePinnersOrderDirectionField? Direction { get; set; } = default;

        public DevicePinnersOrderField() {
            
        }
    }
}