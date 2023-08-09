using System.IO;
using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;

namespace Box.Schemas {
    public class ShieldInformationBarrier {
        [JsonPropertyName("id")]
        public string Id { get; }

        [JsonPropertyName("type")]
        public ShieldInformationBarrierTypeField Type { get; }

        [JsonPropertyName("enterprise")]
        public EnterpriseBase Enterprise { get; }

        [JsonPropertyName("status")]
        public ShieldInformationBarrierStatusField Status { get; }

        [JsonPropertyName("created_at")]
        public string CreatedAt { get; }

        [JsonPropertyName("created_by")]
        public UserBase CreatedBy { get; }

        [JsonPropertyName("updated_at")]
        public string UpdatedAt { get; }

        [JsonPropertyName("updated_by")]
        public UserBase UpdatedBy { get; }

        [JsonPropertyName("enabled_at")]
        public string EnabledAt { get; }

        [JsonPropertyName("enabled_by")]
        public UserBase EnabledBy { get; }

        public ShieldInformationBarrier(string id, ShieldInformationBarrierTypeField type, EnterpriseBase enterprise, ShieldInformationBarrierStatusField status, string createdAt, UserBase createdBy, string updatedAt, UserBase updatedBy, string enabledAt, UserBase enabledBy) {
            Id = id;
            Type = type;
            Enterprise = enterprise;
            Status = status;
            CreatedAt = createdAt;
            CreatedBy = createdBy;
            UpdatedAt = updatedAt;
            UpdatedBy = updatedBy;
            EnabledAt = enabledAt;
            EnabledBy = enabledBy;
        }
    }
}