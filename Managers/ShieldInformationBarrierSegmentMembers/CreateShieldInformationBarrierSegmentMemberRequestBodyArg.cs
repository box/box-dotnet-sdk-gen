using System.IO;
using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text.Json.Serialization;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class CreateShieldInformationBarrierSegmentMemberRequestBodyArg {
        [JsonPropertyName("type")]
        public CreateShieldInformationBarrierSegmentMemberRequestBodyArgTypeField Type { get; }

        [JsonPropertyName("shield_information_barrier")]
        public ShieldInformationBarrierBase ShieldInformationBarrier { get; }

        [JsonPropertyName("shield_information_barrier_segment")]
        public CreateShieldInformationBarrierSegmentMemberRequestBodyArgShieldInformationBarrierSegmentField ShieldInformationBarrierSegment { get; }

        [JsonPropertyName("user")]
        public UserBase User { get; }

        public CreateShieldInformationBarrierSegmentMemberRequestBodyArg(CreateShieldInformationBarrierSegmentMemberRequestBodyArgTypeField type, ShieldInformationBarrierBase shieldInformationBarrier, CreateShieldInformationBarrierSegmentMemberRequestBodyArgShieldInformationBarrierSegmentField shieldInformationBarrierSegment, UserBase user) {
            Type = type;
            ShieldInformationBarrier = shieldInformationBarrier;
            ShieldInformationBarrierSegment = shieldInformationBarrierSegment;
            User = user;
        }
    }
}