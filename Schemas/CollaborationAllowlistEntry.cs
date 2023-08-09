using System.IO;
using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;

namespace Box.Schemas {
    public class CollaborationAllowlistEntry {
        [JsonPropertyName("id")]
        public string Id { get; }

        [JsonPropertyName("type")]
        public CollaborationAllowlistEntryTypeField Type { get; }

        [JsonPropertyName("domain")]
        public string Domain { get; }

        [JsonPropertyName("direction")]
        public CollaborationAllowlistEntryDirectionField Direction { get; }

        [JsonPropertyName("enterprise")]
        public CollaborationAllowlistEntryEnterpriseField Enterprise { get; }

        [JsonPropertyName("created_at")]
        public string CreatedAt { get; }

        public CollaborationAllowlistEntry(string id, CollaborationAllowlistEntryTypeField type, string domain, CollaborationAllowlistEntryDirectionField direction, CollaborationAllowlistEntryEnterpriseField enterprise, string createdAt) {
            Id = id;
            Type = type;
            Domain = domain;
            Direction = direction;
            Enterprise = enterprise;
            CreatedAt = createdAt;
        }
    }
}