using Unions;
using System.Text.Json.Serialization;
using Box.Sdk.Gen.Schemas;

namespace Box.Sdk.Gen.Schemas {
    public class ShieldInformationBarrierSegmentRestriction : ShieldInformationBarrierSegmentRestrictionMini {
        [JsonPropertyName("shield_information_barrier")]
        public ShieldInformationBarrierBase? ShieldInformationBarrier { get; init; }

        /// <summary>
        /// ISO date time string when this
        /// shield information barrier
        /// Segment Restriction object was created.
        /// </summary>
        [JsonPropertyName("created_at")]
        public System.DateTimeOffset? CreatedAt { get; init; }

        [JsonPropertyName("created_by")]
        public UserBase? CreatedBy { get; init; }

        /// <summary>
        /// ISO date time string when this
        /// shield information barrier segment
        /// Restriction was updated.
        /// </summary>
        [JsonPropertyName("updated_at")]
        public System.DateTimeOffset? UpdatedAt { get; init; }

        [JsonPropertyName("updated_by")]
        public UserBase? UpdatedBy { get; init; }

        public ShieldInformationBarrierSegmentRestriction(ShieldInformationBarrierSegmentRestrictionMiniShieldInformationBarrierSegmentField shieldInformationBarrierSegment, ShieldInformationBarrierSegmentRestrictionMiniRestrictedSegmentField restrictedSegment) : base(shieldInformationBarrierSegment, restrictedSegment) {
            
        }
    }
}