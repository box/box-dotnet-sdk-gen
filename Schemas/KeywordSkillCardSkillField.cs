using System.IO;
using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Text.Json;

namespace Box.Schemas {
    public class KeywordSkillCardSkillField {
        [JsonPropertyName("type")]
        public KeywordSkillCardSkillFieldTypeField Type { get; }

        [JsonPropertyName("id")]
        public string Id { get; }

        public KeywordSkillCardSkillField(KeywordSkillCardSkillFieldTypeField type, string id) {
            Type = type;
            Id = id;
        }
    }
}