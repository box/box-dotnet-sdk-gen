using System.IO;
using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;

namespace Box.Schemas {
    public class CollaborationAllowlistEntryEnterpriseField {
        [JsonPropertyName("id")]
        public string Id { get; }

        [JsonPropertyName("type")]
        public CollaborationAllowlistEntryEnterpriseFieldTypeField Type { get; }

        [JsonPropertyName("name")]
        public string Name { get; }

        public CollaborationAllowlistEntryEnterpriseField(string id, CollaborationAllowlistEntryEnterpriseFieldTypeField type, string name) {
            Id = id;
            Type = type;
            Name = name;
        }
    }
}