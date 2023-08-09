using System.IO;
using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;

namespace Box.Schemas {
    public class CollaborationAllowlistExemptTargetEnterpriseField {
        [JsonPropertyName("id")]
        public string Id { get; }

        [JsonPropertyName("type")]
        public CollaborationAllowlistExemptTargetEnterpriseFieldTypeField Type { get; }

        [JsonPropertyName("name")]
        public string Name { get; }

        public CollaborationAllowlistExemptTargetEnterpriseField(string id, CollaborationAllowlistExemptTargetEnterpriseFieldTypeField type, string name) {
            Id = id;
            Type = type;
            Name = name;
        }
    }
}