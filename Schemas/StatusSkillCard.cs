using System.IO;
using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Text.Json;

namespace Box.Schemas {
    public class StatusSkillCard {
        [JsonPropertyName("created_at")]
        public string CreatedAt { get; }

        [JsonPropertyName("type")]
        public StatusSkillCardTypeField Type { get; }

        [JsonPropertyName("skill_card_type")]
        public StatusSkillCardSkillCardTypeField SkillCardType { get; }

        [JsonPropertyName("skill_card_title")]
        public StatusSkillCardSkillCardTitleField SkillCardTitle { get; }

        [JsonPropertyName("status")]
        public StatusSkillCardStatusField Status { get; }

        [JsonPropertyName("skill")]
        public StatusSkillCardSkillField Skill { get; }

        [JsonPropertyName("invocation")]
        public StatusSkillCardInvocationField Invocation { get; }

        public StatusSkillCard(string createdAt, StatusSkillCardTypeField type, StatusSkillCardSkillCardTypeField skillCardType, StatusSkillCardSkillCardTitleField skillCardTitle, StatusSkillCardStatusField status, StatusSkillCardSkillField skill, StatusSkillCardInvocationField invocation) {
            CreatedAt = createdAt;
            Type = type;
            SkillCardType = skillCardType;
            SkillCardTitle = skillCardTitle;
            Status = status;
            Skill = skill;
            Invocation = invocation;
        }
    }
}