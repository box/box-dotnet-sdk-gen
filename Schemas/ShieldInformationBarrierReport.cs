using System.IO;
using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Text.Json;

namespace Box.Schemas {
    public class ShieldInformationBarrierReport : ShieldInformationBarrierReportBase {
        [JsonPropertyName("shield_information_barrier")]
        public ShieldInformationBarrierReference ShieldInformationBarrier { get; }

        [JsonPropertyName("status")]
        public ShieldInformationBarrierReportStatusField Status { get; }

        [JsonPropertyName("details")]
        public ShieldInformationBarrierReportDetails Details { get; }

        [JsonPropertyName("created_at")]
        public string CreatedAt { get; }

        [JsonPropertyName("created_by")]
        public UserBase CreatedBy { get; }

        [JsonPropertyName("updated_at")]
        public string UpdatedAt { get; }

        public ShieldInformationBarrierReport(string id, ShieldInformationBarrierReportBaseTypeField type, ShieldInformationBarrierReference shieldInformationBarrier, ShieldInformationBarrierReportStatusField status, ShieldInformationBarrierReportDetails details, string createdAt, UserBase createdBy, string updatedAt) : base(id, type) {
            ShieldInformationBarrier = shieldInformationBarrier;
            Status = status;
            Details = details;
            CreatedAt = createdAt;
            CreatedBy = createdBy;
            UpdatedAt = updatedAt;
        }
    }
}