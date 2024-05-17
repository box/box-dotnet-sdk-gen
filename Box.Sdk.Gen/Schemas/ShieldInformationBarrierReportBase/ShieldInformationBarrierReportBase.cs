using Unions;
using System.Text.Json.Serialization;

namespace Box.Sdk.Gen.Schemas {
    public class ShieldInformationBarrierReportBase {
        /// <summary>
        /// The unique identifier for the shield information barrier report
        /// </summary>
        [JsonPropertyName("id")]
        public string? Id { get; init; }

        /// <summary>
        /// The type of the shield information barrier report
        /// </summary>
        [JsonPropertyName("type")]
        public ShieldInformationBarrierReportBaseTypeField? Type { get; init; }

        public ShieldInformationBarrierReportBase() {
            
        }
    }
}