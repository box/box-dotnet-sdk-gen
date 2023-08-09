using System.IO;
using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Text.Json;

namespace Box.Schemas {
    public class TranscriptSkillCardSkillField {
        [JsonPropertyName("type")]
        public TranscriptSkillCardSkillFieldTypeField Type { get; }

        [JsonPropertyName("id")]
        public string Id { get; }

        public TranscriptSkillCardSkillField(TranscriptSkillCardSkillFieldTypeField type, string id) {
            Type = type;
            Id = id;
        }
    }
}