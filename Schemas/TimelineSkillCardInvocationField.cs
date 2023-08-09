using System.IO;
using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Text.Json;

namespace Box.Schemas {
    public class TimelineSkillCardInvocationField {
        [JsonPropertyName("type")]
        public TimelineSkillCardInvocationFieldTypeField Type { get; }

        [JsonPropertyName("id")]
        public string Id { get; }

        public TimelineSkillCardInvocationField(TimelineSkillCardInvocationFieldTypeField type, string id) {
            Type = type;
            Id = id;
        }
    }
}