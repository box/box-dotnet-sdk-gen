using Unions;
using System.Text.Json.Serialization;

namespace Box.Sdk.Gen.Schemas {
    public class ShieldInformationBarrierBase {
        /// <summary>
        /// The unique identifier for the shield information barrier
        /// </summary>
        [JsonPropertyName("id")]
        public string? Id { get; init; }

        /// <summary>
        /// The type of the shield information barrier
        /// </summary>
        [JsonPropertyName("type")]
        public ShieldInformationBarrierBaseTypeField? Type { get; init; }

        public ShieldInformationBarrierBase() {
            
        }
    }
}