using System.IO;
using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text.Json.Serialization;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class CreateShieldInformationBarrierSegmentRestrictionRequestBodyArg {
        [JsonPropertyName("type")]
        public CreateShieldInformationBarrierSegmentRestrictionRequestBodyArgTypeField Type { get; }

        [JsonPropertyName("shield_information_barrier")]
        public ShieldInformationBarrierBase ShieldInformationBarrier { get; }

        [JsonPropertyName("shield_information_barrier_segment")]
        public CreateShieldInformationBarrierSegmentRestrictionRequestBodyArgShieldInformationBarrierSegmentField ShieldInformationBarrierSegment { get; }

        [JsonPropertyName("restricted_segment")]
        public CreateShieldInformationBarrierSegmentRestrictionRequestBodyArgRestrictedSegmentField RestrictedSegment { get; }

        public CreateShieldInformationBarrierSegmentRestrictionRequestBodyArg(CreateShieldInformationBarrierSegmentRestrictionRequestBodyArgTypeField type, ShieldInformationBarrierBase shieldInformationBarrier, CreateShieldInformationBarrierSegmentRestrictionRequestBodyArgShieldInformationBarrierSegmentField shieldInformationBarrierSegment, CreateShieldInformationBarrierSegmentRestrictionRequestBodyArgRestrictedSegmentField restrictedSegment) {
            Type = type;
            ShieldInformationBarrier = shieldInformationBarrier;
            ShieldInformationBarrierSegment = shieldInformationBarrierSegment;
            RestrictedSegment = restrictedSegment;
        }
    }
}