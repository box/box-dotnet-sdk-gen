using System.IO;
using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Text.Json;

namespace Box.Schemas {
    public class KeywordSkillCard {
        [JsonPropertyName("created_at")]
        public string CreatedAt { get; }

        [JsonPropertyName("type")]
        public KeywordSkillCardTypeField Type { get; }

        [JsonPropertyName("skill_card_type")]
        public KeywordSkillCardSkillCardTypeField SkillCardType { get; }

        [JsonPropertyName("skill_card_title")]
        public KeywordSkillCardSkillCardTitleField SkillCardTitle { get; }

        [JsonPropertyName("skill")]
        public KeywordSkillCardSkillField Skill { get; }

        [JsonPropertyName("invocation")]
        public KeywordSkillCardInvocationField Invocation { get; }

        [JsonPropertyName("entries")]
        public IReadOnlyList<KeywordSkillCardEntriesField> Entries { get; }

        public KeywordSkillCard(string createdAt, KeywordSkillCardTypeField type, KeywordSkillCardSkillCardTypeField skillCardType, KeywordSkillCardSkillCardTitleField skillCardTitle, KeywordSkillCardSkillField skill, KeywordSkillCardInvocationField invocation, IReadOnlyList<KeywordSkillCardEntriesField> entries) {
            CreatedAt = createdAt;
            Type = type;
            SkillCardType = skillCardType;
            SkillCardTitle = skillCardTitle;
            Skill = skill;
            Invocation = invocation;
            Entries = entries;
        }
    }
}