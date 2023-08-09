using System.IO;
using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;

namespace Box.Schemas {
    public class StoragePolicyAssignmentAssignedToField {
        [JsonPropertyName("id")]
        public string Id { get; }

        [JsonPropertyName("type")]
        public string Type { get; }

        public StoragePolicyAssignmentAssignedToField(string id, string type) {
            Id = id;
            Type = type;
        }
    }
}