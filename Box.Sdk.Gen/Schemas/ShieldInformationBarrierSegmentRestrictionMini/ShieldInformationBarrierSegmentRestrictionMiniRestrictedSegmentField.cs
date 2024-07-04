using Box.Sdk.Gen;
using System.Text.Json.Serialization;
using Box.Sdk.Gen.Internal;
using Box.Sdk.Gen.Schemas;

namespace Box.Sdk.Gen.Schemas {
    public class ShieldInformationBarrierSegmentRestrictionMiniRestrictedSegmentField {
        /// <summary>
        /// The ID reference of the
        /// restricted shield information barrier segment.
        /// </summary>
        [JsonPropertyName("id")]
        public string? Id { get; init; }

        /// <summary>
        /// The type of the shield information segment
        /// </summary>
        [JsonPropertyName("type")]
        [JsonConverter(typeof(StringEnumConverter<ShieldInformationBarrierSegmentRestrictionMiniRestrictedSegmentTypeField>))]
        public StringEnum<ShieldInformationBarrierSegmentRestrictionMiniRestrictedSegmentTypeField>? Type { get; init; }

        public ShieldInformationBarrierSegmentRestrictionMiniRestrictedSegmentField() {
            
        }
    }
}