using System.IO;
using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;

namespace Box.Schemas {
    public class ShieldInformationBarrierSegment {
        [JsonPropertyName("id")]
        public string Id { get; }

        [JsonPropertyName("type")]
        public ShieldInformationBarrierSegmentTypeField Type { get; }

        [JsonPropertyName("shield_information_barrier")]
        public ShieldInformationBarrierBase ShieldInformationBarrier { get; }

        [JsonPropertyName("name")]
        public string Name { get; }

        [JsonPropertyName("description")]
        public string Description { get; }

        [JsonPropertyName("created_at")]
        public string CreatedAt { get; }

        [JsonPropertyName("created_by")]
        public UserBase CreatedBy { get; }

        [JsonPropertyName("updated_at")]
        public string UpdatedAt { get; }

        [JsonPropertyName("updated_by")]
        public UserBase UpdatedBy { get; }

        public ShieldInformationBarrierSegment(string id, ShieldInformationBarrierSegmentTypeField type, ShieldInformationBarrierBase shieldInformationBarrier, string name, string description, string createdAt, UserBase createdBy, string updatedAt, UserBase updatedBy) {
            Id = id;
            Type = type;
            ShieldInformationBarrier = shieldInformationBarrier;
            Name = name;
            Description = description;
            CreatedAt = createdAt;
            CreatedBy = createdBy;
            UpdatedAt = updatedAt;
            UpdatedBy = updatedBy;
        }
    }
}