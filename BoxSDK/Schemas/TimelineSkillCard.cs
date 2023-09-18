using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Text.Json;

namespace Box.Schemas {
    public class TimelineSkillCard {
        /// <summary>
        /// The optional date and time this card was created at.
        /// </summary>
        [JsonPropertyName("created_at")]
        public string? CreatedAt { get; set; } = default;

        /// <summary>
        /// `skill_card`
        /// </summary>
        [JsonPropertyName("type")]
        public TimelineSkillCardTypeField Type { get; set; }

        /// <summary>
        /// `timeline`
        /// </summary>
        [JsonPropertyName("skill_card_type")]
        public TimelineSkillCardSkillCardTypeField SkillCardType { get; set; }

        /// <summary>
        /// The title of the card.
        /// </summary>
        [JsonPropertyName("skill_card_title")]
        public TimelineSkillCardSkillCardTitleField? SkillCardTitle { get; set; } = default;

        /// <summary>
        /// The service that applied this metadata.
        /// </summary>
        [JsonPropertyName("skill")]
        public TimelineSkillCardSkillField Skill { get; set; }

        /// <summary>
        /// The invocation of this service, used to track
        /// which instance of a service applied the metadata.
        /// </summary>
        [JsonPropertyName("invocation")]
        public TimelineSkillCardInvocationField Invocation { get; set; }

        /// <summary>
        /// An total duration in seconds of the timeline.
        /// </summary>
        [JsonPropertyName("duration")]
        public int? Duration { get; set; } = default;

        /// <summary>
        /// A list of entries on the timeline.
        /// </summary>
        [JsonPropertyName("entries")]
        public IReadOnlyList<TimelineSkillCardEntriesField> Entries { get; set; }

        public TimelineSkillCard(TimelineSkillCardTypeField type, TimelineSkillCardSkillCardTypeField skillCardType, TimelineSkillCardSkillField skill, TimelineSkillCardInvocationField invocation, IReadOnlyList<TimelineSkillCardEntriesField> entries) {
            Type = type;
            SkillCardType = skillCardType;
            Skill = skill;
            Invocation = invocation;
            Entries = entries;
        }
    }
}