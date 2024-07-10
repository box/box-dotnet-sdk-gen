using Box.Sdk.Gen;
using System.Text.Json.Serialization;
using Box.Sdk.Gen.Internal;

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
        [JsonConverter(typeof(StringEnumConverter<ShieldInformationBarrierReportBaseTypeField>))]
        public StringEnum<ShieldInformationBarrierReportBaseTypeField>? Type { get; init; }

        public ShieldInformationBarrierReportBase() {
            
        }
    }
}