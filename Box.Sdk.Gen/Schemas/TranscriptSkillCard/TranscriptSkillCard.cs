using Box.Sdk.Gen;
using System.Text.Json.Serialization;
using Box.Sdk.Gen.Internal;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;

namespace Box.Sdk.Gen.Schemas {
    public class TranscriptSkillCard {
        /// <summary>
        /// The optional date and time this card was created at.
        /// </summary>
        [JsonPropertyName("created_at")]
        public System.DateTimeOffset? CreatedAt { get; init; }

        /// <summary>
        /// `skill_card`
        /// </summary>
        [JsonPropertyName("type")]
        [JsonConverter(typeof(StringEnumConverter<TranscriptSkillCardTypeField>))]
        public StringEnum<TranscriptSkillCardTypeField> Type { get; }

        /// <summary>
        /// `transcript`
        /// </summary>
        [JsonPropertyName("skill_card_type")]
        [JsonConverter(typeof(StringEnumConverter<TranscriptSkillCardSkillCardTypeField>))]
        public StringEnum<TranscriptSkillCardSkillCardTypeField> SkillCardType { get; }

        /// <summary>
        /// The title of the card.
        /// </summary>
        [JsonPropertyName("skill_card_title")]
        public TranscriptSkillCardSkillCardTitleField? SkillCardTitle { get; init; }

        /// <summary>
        /// The service that applied this metadata.
        /// </summary>
        [JsonPropertyName("skill")]
        public TranscriptSkillCardSkillField Skill { get; }

        /// <summary>
        /// The invocation of this service, used to track
        /// which instance of a service applied the metadata.
        /// </summary>
        [JsonPropertyName("invocation")]
        public TranscriptSkillCardInvocationField Invocation { get; }

        /// <summary>
        /// An optional total duration in seconds.
        /// 
        /// Used with a `skill_card_type` of `transcript` or
        /// `timeline`.
        /// </summary>
        [JsonPropertyName("duration")]
        public long? Duration { get; init; }

        /// <summary>
        /// An list of entries for the card. This represents the individual entries of
        /// the transcription.
        /// </summary>
        [JsonPropertyName("entries")]
        public IReadOnlyList<TranscriptSkillCardEntriesField> Entries { get; }

        public TranscriptSkillCard(TranscriptSkillCardSkillField skill, TranscriptSkillCardInvocationField invocation, IReadOnlyList<TranscriptSkillCardEntriesField> entries, TranscriptSkillCardTypeField type = TranscriptSkillCardTypeField.SkillCard, TranscriptSkillCardSkillCardTypeField skillCardType = TranscriptSkillCardSkillCardTypeField.Transcript) {
            Type = type;
            SkillCardType = skillCardType;
            Skill = skill;
            Invocation = invocation;
            Entries = entries;
        }
        
        [JsonConstructorAttribute]
        internal TranscriptSkillCard(TranscriptSkillCardSkillField skill, TranscriptSkillCardInvocationField invocation, IReadOnlyList<TranscriptSkillCardEntriesField> entries, StringEnum<TranscriptSkillCardTypeField> type, StringEnum<TranscriptSkillCardSkillCardTypeField> skillCardType) {
            Type = TranscriptSkillCardTypeField.SkillCard;
            SkillCardType = TranscriptSkillCardSkillCardTypeField.Transcript;
            Skill = skill;
            Invocation = invocation;
            Entries = entries;
        }
    }
}