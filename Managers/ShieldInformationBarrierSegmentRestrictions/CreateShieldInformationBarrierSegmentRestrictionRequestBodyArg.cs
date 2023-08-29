using System.IO;
using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text.Json.Serialization;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class CreateShieldInformationBarrierSegmentRestrictionRequestBodyArg {
        /// <summary>
        /// The type of the shield barrier segment
        /// restriction for this member.
        /// </summary>
        [JsonPropertyName("type")]
        public CreateShieldInformationBarrierSegmentRestrictionRequestBodyArgTypeField Type { get; set; }

        [JsonPropertyName("shield_information_barrier")]
        public ShieldInformationBarrierBase? ShieldInformationBarrier { get; set; } = default;

        /// <summary>
        /// The `type` and `id` of the requested
        /// shield information barrier segment.
        /// </summary>
        [JsonPropertyName("shield_information_barrier_segment")]
        public CreateShieldInformationBarrierSegmentRestrictionRequestBodyArgShieldInformationBarrierSegmentField ShieldInformationBarrierSegment { get; set; }

        /// <summary>
        /// The `type` and `id` of the restricted
        /// shield information barrier segment.
        /// </summary>
        [JsonPropertyName("restricted_segment")]
        public CreateShieldInformationBarrierSegmentRestrictionRequestBodyArgRestrictedSegmentField RestrictedSegment { get; set; }

        public CreateShieldInformationBarrierSegmentRestrictionRequestBodyArg(CreateShieldInformationBarrierSegmentRestrictionRequestBodyArgTypeField type, CreateShieldInformationBarrierSegmentRestrictionRequestBodyArgShieldInformationBarrierSegmentField shieldInformationBarrierSegment, CreateShieldInformationBarrierSegmentRestrictionRequestBodyArgRestrictedSegmentField restrictedSegment) {
            Type = type;
            ShieldInformationBarrierSegment = shieldInformationBarrierSegment;
            RestrictedSegment = restrictedSegment;
        }
    }
}