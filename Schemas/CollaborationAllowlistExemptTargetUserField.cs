using System.IO;
using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;

namespace Box.Schemas {
    public class CollaborationAllowlistExemptTargetUserField {
        [JsonPropertyName("id")]
        public string Id { get; }

        [JsonPropertyName("type")]
        public CollaborationAllowlistExemptTargetUserFieldTypeField Type { get; }

        [JsonPropertyName("name")]
        public string Name { get; }

        public CollaborationAllowlistExemptTargetUserField(string id, CollaborationAllowlistExemptTargetUserFieldTypeField type, string name) {
            Id = id;
            Type = type;
            Name = name;
        }
    }
}