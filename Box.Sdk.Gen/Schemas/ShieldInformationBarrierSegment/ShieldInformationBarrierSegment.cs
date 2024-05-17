using Unions;
using System.Text.Json.Serialization;
using Box.Sdk.Gen.Schemas;

namespace Box.Sdk.Gen.Schemas {
    public class ShieldInformationBarrierSegment {
        /// <summary>
        /// The unique identifier for the shield information barrier segment
        /// </summary>
        [JsonPropertyName("id")]
        public string? Id { get; init; }

        /// <summary>
        /// The type of the shield information barrier segment
        /// </summary>
        [JsonPropertyName("type")]
        public ShieldInformationBarrierSegmentTypeField? Type { get; init; }

        [JsonPropertyName("shield_information_barrier")]
        public ShieldInformationBarrierBase? ShieldInformationBarrier { get; init; }

        /// <summary>
        /// Name of the shield information barrier segment
        /// </summary>
        [JsonPropertyName("name")]
        public string? Name { get; init; }

        /// <summary>
        /// Description of the shield information barrier segment
        /// </summary>
        [JsonPropertyName("description")]
        public string? Description { get; init; }

        /// <summary>
        /// ISO date time string when this shield information
        /// barrier object was created.
        /// </summary>
        [JsonPropertyName("created_at")]
        public System.DateTimeOffset? CreatedAt { get; init; }

        [JsonPropertyName("created_by")]
        public UserBase? CreatedBy { get; init; }

        /// <summary>
        /// ISO date time string when this
        /// shield information barrier segment was updated.
        /// </summary>
        [JsonPropertyName("updated_at")]
        public System.DateTimeOffset? UpdatedAt { get; init; }

        [JsonPropertyName("updated_by")]
        public UserBase? UpdatedBy { get; init; }

        public ShieldInformationBarrierSegment() {
            
        }
    }
}