using Unions;
using System.Text.Json.Serialization;
using Box.Sdk.Gen.Schemas;

namespace Box.Sdk.Gen.Schemas {
    public class ShieldInformationBarrierReport : ShieldInformationBarrierReportBase {
        [JsonPropertyName("shield_information_barrier")]
        public ShieldInformationBarrierReference? ShieldInformationBarrier { get; init; }

        /// <summary>
        /// Status of the shield information report
        /// </summary>
        [JsonPropertyName("status")]
        public ShieldInformationBarrierReportStatusField? Status { get; init; }

        [JsonPropertyName("details")]
        public ShieldInformationBarrierReportDetails? Details { get; init; }

        /// <summary>
        /// ISO date time string when this
        /// shield information barrier report object was created.
        /// </summary>
        [JsonPropertyName("created_at")]
        public System.DateTimeOffset? CreatedAt { get; init; }

        [JsonPropertyName("created_by")]
        public UserBase? CreatedBy { get; init; }

        /// <summary>
        /// ISO date time string when this
        /// shield information barrier report was updated.
        /// </summary>
        [JsonPropertyName("updated_at")]
        public System.DateTimeOffset? UpdatedAt { get; init; }

        public ShieldInformationBarrierReport() {
            
        }
    }
}