using Unions;
using System.Text.Json.Serialization;

namespace Box.Sdk.Gen.Schemas {
    public class ShieldInformationBarrierReportDetails {
        [JsonPropertyName("details")]
        public ShieldInformationBarrierReportDetailsDetailsField? Details { get; init; }

        public ShieldInformationBarrierReportDetails() {
            
        }
    }
}