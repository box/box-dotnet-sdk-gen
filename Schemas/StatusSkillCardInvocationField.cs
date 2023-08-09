using System.IO;
using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Text.Json;

namespace Box.Schemas {
    public class StatusSkillCardInvocationField {
        [JsonPropertyName("type")]
        public StatusSkillCardInvocationFieldTypeField Type { get; }

        [JsonPropertyName("id")]
        public string Id { get; }

        public StatusSkillCardInvocationField(StatusSkillCardInvocationFieldTypeField type, string id) {
            Type = type;
            Id = id;
        }
    }
}