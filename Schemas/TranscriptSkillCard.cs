using System.IO;
using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Text.Json;

namespace Box.Schemas {
    public class TranscriptSkillCard {
        [JsonPropertyName("created_at")]
        public string CreatedAt { get; }

        [JsonPropertyName("type")]
        public TranscriptSkillCardTypeField Type { get; }

        [JsonPropertyName("skill_card_type")]
        public TranscriptSkillCardSkillCardTypeField SkillCardType { get; }

        [JsonPropertyName("skill_card_title")]
        public TranscriptSkillCardSkillCardTitleField SkillCardTitle { get; }

        [JsonPropertyName("skill")]
        public TranscriptSkillCardSkillField Skill { get; }

        [JsonPropertyName("invocation")]
        public TranscriptSkillCardInvocationField Invocation { get; }

        [JsonPropertyName("duration")]
        public int? Duration { get; }

        [JsonPropertyName("entries")]
        public IReadOnlyList<TranscriptSkillCardEntriesField> Entries { get; }

        public TranscriptSkillCard(string createdAt, TranscriptSkillCardTypeField type, TranscriptSkillCardSkillCardTypeField skillCardType, TranscriptSkillCardSkillCardTitleField skillCardTitle, TranscriptSkillCardSkillField skill, TranscriptSkillCardInvocationField invocation, int? duration, IReadOnlyList<TranscriptSkillCardEntriesField> entries) {
            CreatedAt = createdAt;
            Type = type;
            SkillCardType = skillCardType;
            SkillCardTitle = skillCardTitle;
            Skill = skill;
            Invocation = invocation;
            Duration = duration;
            Entries = entries;
        }
    }
}