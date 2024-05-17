using Unions;
using System.Text.Json.Serialization;
using Box.Sdk.Gen.Schemas;

namespace Box.Sdk.Gen.Schemas {
    public class ShieldInformationBarrierSegmentRestrictionMiniShieldInformationBarrierSegmentField {
        /// <summary>
        /// The ID reference of the
        /// requesting shield information barrier segment.
        /// </summary>
        [JsonPropertyName("id")]
        public string? Id { get; init; }

        /// <summary>
        /// The type of the shield information barrier segment
        /// </summary>
        [JsonPropertyName("type")]
        public ShieldInformationBarrierSegmentRestrictionMiniShieldInformationBarrierSegmentTypeField? Type { get; init; }

        public ShieldInformationBarrierSegmentRestrictionMiniShieldInformationBarrierSegmentField() {
            
        }
    }
}