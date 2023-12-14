using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text.Json.Serialization;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class CreateShieldInformationBarrierSegmentMemberRequestBody {
        /// <summary>
        /// -| A type of the shield barrier segment member.
        /// </summary>
        [JsonPropertyName("type")]
        public CreateShieldInformationBarrierSegmentMemberRequestBodyTypeField? Type { get; set; } = default;

        [JsonPropertyName("shield_information_barrier")]
        public ShieldInformationBarrierBase? ShieldInformationBarrier { get; set; } = default;

        /// <summary>
        /// The `type` and `id` of the
        /// requested shield information barrier segment.
        /// </summary>
        [JsonPropertyName("shield_information_barrier_segment")]
        public CreateShieldInformationBarrierSegmentMemberRequestBodyShieldInformationBarrierSegmentField ShieldInformationBarrierSegment { get; set; }

        /// <summary>
        /// User to which restriction will be applied.
        /// </summary>
        [JsonPropertyName("user")]
        public UserBase User { get; set; }

        public CreateShieldInformationBarrierSegmentMemberRequestBody(CreateShieldInformationBarrierSegmentMemberRequestBodyShieldInformationBarrierSegmentField shieldInformationBarrierSegment, UserBase user) {
            ShieldInformationBarrierSegment = shieldInformationBarrierSegment;
            User = user;
        }
    }
}