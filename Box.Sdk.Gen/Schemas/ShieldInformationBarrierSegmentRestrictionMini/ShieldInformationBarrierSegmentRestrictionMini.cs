using Unions;
using Box.Sdk.Gen;
using System.Text.Json.Serialization;
using Serializer;
using Box.Sdk.Gen.Schemas;

namespace Box.Sdk.Gen.Schemas {
    public class ShieldInformationBarrierSegmentRestrictionMini : ShieldInformationBarrierSegmentRestrictionBase {
        /// <summary>
        /// The `type` and `id` of the
        /// requested shield information barrier segment.
        /// </summary>
        [JsonPropertyName("shield_information_barrier_segment")]
        public ShieldInformationBarrierSegmentRestrictionMiniShieldInformationBarrierSegmentField ShieldInformationBarrierSegment { get; }

        /// <summary>
        /// The `type` and `id` of the
        /// restricted shield information barrier segment.
        /// </summary>
        [JsonPropertyName("restricted_segment")]
        public ShieldInformationBarrierSegmentRestrictionMiniRestrictedSegmentField RestrictedSegment { get; }

        public ShieldInformationBarrierSegmentRestrictionMini(ShieldInformationBarrierSegmentRestrictionMiniShieldInformationBarrierSegmentField shieldInformationBarrierSegment, ShieldInformationBarrierSegmentRestrictionMiniRestrictedSegmentField restrictedSegment) {
            ShieldInformationBarrierSegment = shieldInformationBarrierSegment;
            RestrictedSegment = restrictedSegment;
        }
    }
}