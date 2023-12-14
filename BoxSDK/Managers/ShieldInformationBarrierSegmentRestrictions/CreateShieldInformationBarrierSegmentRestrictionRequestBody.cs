using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text.Json.Serialization;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class CreateShieldInformationBarrierSegmentRestrictionRequestBody {
        /// <summary>
        /// The type of the shield barrier segment
        /// restriction for this member.
        /// </summary>
        [JsonPropertyName("type")]
        public CreateShieldInformationBarrierSegmentRestrictionRequestBodyTypeField Type { get; set; }

        [JsonPropertyName("shield_information_barrier")]
        public ShieldInformationBarrierBase? ShieldInformationBarrier { get; set; } = default;

        /// <summary>
        /// The `type` and `id` of the requested
        /// shield information barrier segment.
        /// </summary>
        [JsonPropertyName("shield_information_barrier_segment")]
        public CreateShieldInformationBarrierSegmentRestrictionRequestBodyShieldInformationBarrierSegmentField ShieldInformationBarrierSegment { get; set; }

        /// <summary>
        /// The `type` and `id` of the restricted
        /// shield information barrier segment.
        /// </summary>
        [JsonPropertyName("restricted_segment")]
        public CreateShieldInformationBarrierSegmentRestrictionRequestBodyRestrictedSegmentField RestrictedSegment { get; set; }

        public CreateShieldInformationBarrierSegmentRestrictionRequestBody(CreateShieldInformationBarrierSegmentRestrictionRequestBodyTypeField type, CreateShieldInformationBarrierSegmentRestrictionRequestBodyShieldInformationBarrierSegmentField shieldInformationBarrierSegment, CreateShieldInformationBarrierSegmentRestrictionRequestBodyRestrictedSegmentField restrictedSegment) {
            Type = type;
            ShieldInformationBarrierSegment = shieldInformationBarrierSegment;
            RestrictedSegment = restrictedSegment;
        }
    }
}