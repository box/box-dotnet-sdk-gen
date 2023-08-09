using System.IO;
using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Text.Json;

namespace Box.Schemas {
    public class StatusSkillCardSkillField {
        [JsonPropertyName("type")]
        public StatusSkillCardSkillFieldTypeField Type { get; }

        [JsonPropertyName("id")]
        public string Id { get; }

        public StatusSkillCardSkillField(StatusSkillCardSkillFieldTypeField type, string id) {
            Type = type;
            Id = id;
        }
    }
}