using System.IO;
using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text.Json.Serialization;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class CreateShieldInformationBarrierSegmentMemberRequestBodyArg {
        /// <summary>
        /// -| A type of the shield barrier segment member.
        /// </summary>
        [JsonPropertyName("type")]
        public CreateShieldInformationBarrierSegmentMemberRequestBodyArgTypeField? Type { get; set; } = default;

        [JsonPropertyName("shield_information_barrier")]
        public ShieldInformationBarrierBase? ShieldInformationBarrier { get; set; } = default;

        /// <summary>
        /// The `type` and `id` of the
        /// requested shield information barrier segment.
        /// </summary>
        [JsonPropertyName("shield_information_barrier_segment")]
        public CreateShieldInformationBarrierSegmentMemberRequestBodyArgShieldInformationBarrierSegmentField ShieldInformationBarrierSegment { get; set; }

        [JsonPropertyName("user")]
        public UserBase User { get; set; }

        public CreateShieldInformationBarrierSegmentMemberRequestBodyArg(CreateShieldInformationBarrierSegmentMemberRequestBodyArgShieldInformationBarrierSegmentField shieldInformationBarrierSegment, UserBase user) {
            ShieldInformationBarrierSegment = shieldInformationBarrierSegment;
            User = user;
        }
    }
}