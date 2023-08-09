using System.IO;
using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Text.Json;

namespace Box.Schemas {
    public class SkillInvocation {
        [JsonPropertyName("type")]
        public SkillInvocationTypeField Type { get; }

        [JsonPropertyName("id")]
        public string Id { get; }

        [JsonPropertyName("skill")]
        public SkillInvocationSkillField Skill { get; }

        [JsonPropertyName("token")]
        public SkillInvocationTokenField Token { get; }

        [JsonPropertyName("status")]
        public SkillInvocationStatusField Status { get; }

        [JsonPropertyName("created_at")]
        public string CreatedAt { get; }

        [JsonPropertyName("trigger")]
        public string Trigger { get; }

        [JsonPropertyName("enterprise")]
        public SkillInvocationEnterpriseField Enterprise { get; }

        [JsonPropertyName("source")]
        public SkillInvocationSourceField Source { get; }

        [JsonPropertyName("event")]
        public Event Event { get; }

        public SkillInvocation(SkillInvocationTypeField type, string id, SkillInvocationSkillField skill, SkillInvocationTokenField token, SkillInvocationStatusField status, string createdAt, string trigger, SkillInvocationEnterpriseField enterprise, SkillInvocationSourceField source, Event eventParam) {
            Type = type;
            Id = id;
            Skill = skill;
            Token = token;
            Status = status;
            CreatedAt = createdAt;
            Trigger = trigger;
            Enterprise = enterprise;
            Source = source;
            Event = eventParam;
        }
    }
}