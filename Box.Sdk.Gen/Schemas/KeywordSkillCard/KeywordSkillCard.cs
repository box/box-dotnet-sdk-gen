using Box.Sdk.Gen;
using System.Text.Json.Serialization;
using Box.Sdk.Gen.Internal;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;

namespace Box.Sdk.Gen.Schemas {
    public class KeywordSkillCard {
        /// <summary>
        /// The optional date and time this card was created at.
        /// </summary>
        [JsonPropertyName("created_at")]
        public System.DateTimeOffset? CreatedAt { get; init; }

        /// <summary>
        /// `skill_card`
        /// </summary>
        [JsonPropertyName("type")]
        [JsonConverter(typeof(StringEnumConverter<KeywordSkillCardTypeField>))]
        public StringEnum<KeywordSkillCardTypeField> Type { get; }

        /// <summary>
        /// `keyword`
        /// </summary>
        [JsonPropertyName("skill_card_type")]
        [JsonConverter(typeof(StringEnumConverter<KeywordSkillCardSkillCardTypeField>))]
        public StringEnum<KeywordSkillCardSkillCardTypeField> SkillCardType { get; }

        /// <summary>
        /// The title of the card.
        /// </summary>
        [JsonPropertyName("skill_card_title")]
        public KeywordSkillCardSkillCardTitleField? SkillCardTitle { get; init; }

        /// <summary>
        /// The service that applied this metadata.
        /// </summary>
        [JsonPropertyName("skill")]
        public KeywordSkillCardSkillField Skill { get; }

        /// <summary>
        /// The invocation of this service, used to track
        /// which instance of a service applied the metadata.
        /// </summary>
        [JsonPropertyName("invocation")]
        public KeywordSkillCardInvocationField Invocation { get; }

        /// <summary>
        /// An list of entries in the metadata card.
        /// </summary>
        [JsonPropertyName("entries")]
        public IReadOnlyList<KeywordSkillCardEntriesField> Entries { get; }

        public KeywordSkillCard(KeywordSkillCardSkillField skill, KeywordSkillCardInvocationField invocation, IReadOnlyList<KeywordSkillCardEntriesField> entries, KeywordSkillCardTypeField type = KeywordSkillCardTypeField.SkillCard, KeywordSkillCardSkillCardTypeField skillCardType = KeywordSkillCardSkillCardTypeField.Keyword) {
            Type = type;
            SkillCardType = skillCardType;
            Skill = skill;
            Invocation = invocation;
            Entries = entries;
        }
        
        [JsonConstructorAttribute]
        internal KeywordSkillCard(KeywordSkillCardSkillField skill, KeywordSkillCardInvocationField invocation, IReadOnlyList<KeywordSkillCardEntriesField> entries, StringEnum<KeywordSkillCardTypeField> type, StringEnum<KeywordSkillCardSkillCardTypeField> skillCardType) {
            Type = KeywordSkillCardTypeField.SkillCard;
            SkillCardType = KeywordSkillCardSkillCardTypeField.Keyword;
            Skill = skill;
            Invocation = invocation;
            Entries = entries;
        }
    }
}