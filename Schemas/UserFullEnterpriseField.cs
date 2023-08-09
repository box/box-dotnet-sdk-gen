using System.IO;
using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Text.Json;

namespace Box.Schemas {
    public class UserFullEnterpriseField {
        [JsonPropertyName("id")]
        public string Id { get; }

        [JsonPropertyName("type")]
        public UserFullEnterpriseFieldTypeField Type { get; }

        [JsonPropertyName("name")]
        public string Name { get; }

        public UserFullEnterpriseField(string id, UserFullEnterpriseFieldTypeField type, string name) {
            Id = id;
            Type = type;
            Name = name;
        }
    }
}