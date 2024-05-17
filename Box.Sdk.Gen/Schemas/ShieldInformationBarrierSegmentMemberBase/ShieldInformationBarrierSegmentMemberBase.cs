using Unions;
using System.Text.Json.Serialization;

namespace Box.Sdk.Gen.Schemas {
    public class ShieldInformationBarrierSegmentMemberBase {
        /// <summary>
        /// The unique identifier for the
        /// shield information barrier segment member
        /// </summary>
        [JsonPropertyName("id")]
        public string? Id { get; init; }

        /// <summary>
        /// The type of the shield information barrier segment member
        /// </summary>
        [JsonPropertyName("type")]
        public ShieldInformationBarrierSegmentMemberBaseTypeField? Type { get; init; }

        public ShieldInformationBarrierSegmentMemberBase() {
            
        }
    }
}