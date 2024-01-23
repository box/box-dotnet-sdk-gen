using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Text.Json;

namespace Box.Sdk.Gen.Schemas {
    public class ShieldInformationBarrierReport : ShieldInformationBarrierReportBase {
        [JsonPropertyName("shield_information_barrier")]
        public ShieldInformationBarrierReference? ShieldInformationBarrier { get; set; } = default;

        /// <summary>
        /// Status of the shield information report
        /// </summary>
        [JsonPropertyName("status")]
        public ShieldInformationBarrierReportStatusField? Status { get; set; } = default;

        [JsonPropertyName("details")]
        public ShieldInformationBarrierReportDetails? Details { get; set; } = default;

        /// <summary>
        /// ISO date time string when this
        /// shield information barrier report object was created.
        /// </summary>
        [JsonPropertyName("created_at")]
        public System.DateTimeOffset? CreatedAt { get; set; } = default;

        [JsonPropertyName("created_by")]
        public UserBase? CreatedBy { get; set; } = default;

        /// <summary>
        /// ISO date time string when this
        /// shield information barrier report was updated.
        /// </summary>
        [JsonPropertyName("updated_at")]
        public System.DateTimeOffset? UpdatedAt { get; set; } = default;

        public ShieldInformationBarrierReport() {
            
        }
    }
}