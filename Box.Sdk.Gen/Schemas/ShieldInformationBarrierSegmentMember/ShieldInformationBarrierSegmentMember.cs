using Unions;
using System.Text.Json.Serialization;
using Box.Sdk.Gen.Schemas;

namespace Box.Sdk.Gen.Schemas {
    public class ShieldInformationBarrierSegmentMember : ShieldInformationBarrierSegmentMemberMini {
        [JsonPropertyName("shield_information_barrier")]
        public ShieldInformationBarrierBase? ShieldInformationBarrier { get; init; }

        /// <summary>
        /// The `type` and `id` of the requested
        /// shield information barrier segment.
        /// </summary>
        [JsonPropertyName("shield_information_barrier_segment")]
        public ShieldInformationBarrierSegmentMemberShieldInformationBarrierSegmentField? ShieldInformationBarrierSegment { get; init; }

        /// <summary>
        /// ISO date time string when this shield
        /// information barrier object was created.
        /// </summary>
        [JsonPropertyName("created_at")]
        public System.DateTimeOffset? CreatedAt { get; init; }

        [JsonPropertyName("created_by")]
        public UserBase? CreatedBy { get; init; }

        /// <summary>
        /// ISO date time string when this
        /// shield information barrier segment Member was updated.
        /// </summary>
        [JsonPropertyName("updated_at")]
        public System.DateTimeOffset? UpdatedAt { get; init; }

        [JsonPropertyName("updated_by")]
        public UserBase? UpdatedBy { get; init; }

        public ShieldInformationBarrierSegmentMember() {
            
        }
    }
}