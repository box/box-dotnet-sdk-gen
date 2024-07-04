using Box.Sdk.Gen;
using System.Text.Json.Serialization;
using Box.Sdk.Gen.Internal;
using Box.Sdk.Gen.Schemas;

namespace Box.Sdk.Gen.Schemas {
    public class DevicePinnersOrderField {
        /// <summary>
        /// The field that is ordered by
        /// </summary>
        [JsonPropertyName("by")]
        [JsonConverter(typeof(StringEnumConverter<DevicePinnersOrderByField>))]
        public StringEnum<DevicePinnersOrderByField>? By { get; init; }

        /// <summary>
        /// The direction to order by, either ascending or descending
        /// </summary>
        [JsonPropertyName("direction")]
        [JsonConverter(typeof(StringEnumConverter<DevicePinnersOrderDirectionField>))]
        public StringEnum<DevicePinnersOrderDirectionField>? Direction { get; init; }

        public DevicePinnersOrderField() {
            
        }
    }
}