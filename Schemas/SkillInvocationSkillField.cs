using System.IO;
using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Text.Json;

namespace Box.Schemas {
    public class SkillInvocationSkillField {
        [JsonPropertyName("id")]
        public string Id { get; }

        [JsonPropertyName("type")]
        public SkillInvocationSkillFieldTypeField Type { get; }

        [JsonPropertyName("name")]
        public string Name { get; }

        [JsonPropertyName("api_key")]
        public string ApiKey { get; }

        public SkillInvocationSkillField(string id, SkillInvocationSkillFieldTypeField type, string name, string apiKey) {
            Id = id;
            Type = type;
            Name = name;
            ApiKey = apiKey;
        }
    }
}