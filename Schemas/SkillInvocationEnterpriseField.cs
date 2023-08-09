using System.IO;
using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Text.Json;

namespace Box.Schemas {
    public class SkillInvocationEnterpriseField {
        [JsonPropertyName("id")]
        public string Id { get; }

        [JsonPropertyName("type")]
        public SkillInvocationEnterpriseFieldTypeField Type { get; }

        [JsonPropertyName("name")]
        public string Name { get; }

        public SkillInvocationEnterpriseField(string id, SkillInvocationEnterpriseFieldTypeField type, string name) {
            Id = id;
            Type = type;
            Name = name;
        }
    }
}