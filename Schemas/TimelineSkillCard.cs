using System.IO;
using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Text.Json;

namespace Box.Schemas {
    public class TimelineSkillCard {
        [JsonPropertyName("created_at")]
        public string CreatedAt { get; }

        [JsonPropertyName("type")]
        public TimelineSkillCardTypeField Type { get; }

        [JsonPropertyName("skill_card_type")]
        public TimelineSkillCardSkillCardTypeField SkillCardType { get; }

        [JsonPropertyName("skill_card_title")]
        public TimelineSkillCardSkillCardTitleField SkillCardTitle { get; }

        [JsonPropertyName("skill")]
        public TimelineSkillCardSkillField Skill { get; }

        [JsonPropertyName("invocation")]
        public TimelineSkillCardInvocationField Invocation { get; }

        [JsonPropertyName("duration")]
        public int? Duration { get; }

        [JsonPropertyName("entries")]
        public IReadOnlyList<TimelineSkillCardEntriesField> Entries { get; }

        public TimelineSkillCard(string createdAt, TimelineSkillCardTypeField type, TimelineSkillCardSkillCardTypeField skillCardType, TimelineSkillCardSkillCardTitleField skillCardTitle, TimelineSkillCardSkillField skill, TimelineSkillCardInvocationField invocation, int? duration, IReadOnlyList<TimelineSkillCardEntriesField> entries) {
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