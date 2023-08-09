using System.IO;
using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;

namespace Box.Schemas {
    public class CollaborationAllowlistExemptTarget {
        [JsonPropertyName("id")]
        public string Id { get; }

        [JsonPropertyName("type")]
        public CollaborationAllowlistExemptTargetTypeField Type { get; }

        [JsonPropertyName("enterprise")]
        public CollaborationAllowlistExemptTargetEnterpriseField Enterprise { get; }

        [JsonPropertyName("user")]
        public CollaborationAllowlistExemptTargetUserField User { get; }

        [JsonPropertyName("created_at")]
        public string CreatedAt { get; }

        [JsonPropertyName("modified_at")]
        public string ModifiedAt { get; }

        public CollaborationAllowlistExemptTarget(string id, CollaborationAllowlistExemptTargetTypeField type, CollaborationAllowlistExemptTargetEnterpriseField enterprise, CollaborationAllowlistExemptTargetUserField user, string createdAt, string modifiedAt) {
            Id = id;
            Type = type;
            Enterprise = enterprise;
            User = user;
            CreatedAt = createdAt;
            ModifiedAt = modifiedAt;
        }
    }
}