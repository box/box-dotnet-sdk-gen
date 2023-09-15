using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Text.Json;

namespace Box.Schemas {
    public class TranscriptSkillCard {
        /// <summary>
        /// The optional date and time this card was created at.
        /// </summary>
        [JsonPropertyName("created_at")]
        public string? CreatedAt { get; set; } = default;

        /// <summary>
        /// `skill_card`
        /// </summary>
        [JsonPropertyName("type")]
        public TranscriptSkillCardTypeField Type { get; set; }

        /// <summary>
        /// `transcript`
        /// </summary>
        [JsonPropertyName("skill_card_type")]
        public TranscriptSkillCardSkillCardTypeField SkillCardType { get; set; }

        /// <summary>
        /// The title of the card.
        /// </summary>
        [JsonPropertyName("skill_card_title")]
        public TranscriptSkillCardSkillCardTitleField? SkillCardTitle { get; set; } = default;

        /// <summary>
        /// The service that applied this metadata.
        /// </summary>
        [JsonPropertyName("skill")]
        public TranscriptSkillCardSkillField Skill { get; set; }

        /// <summary>
        /// The invocation of this service, used to track
        /// which instance of a service applied the metadata.
        /// </summary>
        [JsonPropertyName("invocation")]
        public TranscriptSkillCardInvocationField Invocation { get; set; }

        /// <summary>
        /// An optional total duration in seconds.
        /// 
        /// Used with a `skill_card_type` of `transcript` or
        /// `timeline`.
        /// </summary>
        [JsonPropertyName("duration")]
        public int? Duration { get; set; } = default;

        /// <summary>
        /// An list of entries for the card. This represents the individual entries of
        /// the transcription.
        /// </summary>
        [JsonPropertyName("entries")]
        public IReadOnlyList<TranscriptSkillCardEntriesField> Entries { get; set; }

        public TranscriptSkillCard(TranscriptSkillCardTypeField type, TranscriptSkillCardSkillCardTypeField skillCardType, TranscriptSkillCardSkillField skill, TranscriptSkillCardInvocationField invocation, IReadOnlyList<TranscriptSkillCardEntriesField> entries) {
            Type = type;
            SkillCardType = skillCardType;
            Skill = skill;
            Invocation = invocation;
            Entries = entries;
        }
    }
}