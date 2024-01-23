using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Text.Json;

namespace Box.Sdk.Gen.Schemas {
    public class KeywordSkillCard {
        /// <summary>
        /// The optional date and time this card was created at.
        /// </summary>
        [JsonPropertyName("created_at")]
        public System.DateTimeOffset? CreatedAt { get; set; } = default;

        /// <summary>
        /// `skill_card`
        /// </summary>
        [JsonPropertyName("type")]
        public KeywordSkillCardTypeField Type { get; set; }

        /// <summary>
        /// `keyword`
        /// </summary>
        [JsonPropertyName("skill_card_type")]
        public KeywordSkillCardSkillCardTypeField SkillCardType { get; set; }

        /// <summary>
        /// The title of the card.
        /// </summary>
        [JsonPropertyName("skill_card_title")]
        public KeywordSkillCardSkillCardTitleField? SkillCardTitle { get; set; } = default;

        /// <summary>
        /// The service that applied this metadata.
        /// </summary>
        [JsonPropertyName("skill")]
        public KeywordSkillCardSkillField Skill { get; set; }

        /// <summary>
        /// The invocation of this service, used to track
        /// which instance of a service applied the metadata.
        /// </summary>
        [JsonPropertyName("invocation")]
        public KeywordSkillCardInvocationField Invocation { get; set; }

        /// <summary>
        /// An list of entries in the metadata card.
        /// </summary>
        [JsonPropertyName("entries")]
        public IReadOnlyList<KeywordSkillCardEntriesField> Entries { get; set; }

        public KeywordSkillCard(KeywordSkillCardTypeField type, KeywordSkillCardSkillCardTypeField skillCardType, KeywordSkillCardSkillField skill, KeywordSkillCardInvocationField invocation, IReadOnlyList<KeywordSkillCardEntriesField> entries) {
            Type = type;
            SkillCardType = skillCardType;
            Skill = skill;
            Invocation = invocation;
            Entries = entries;
        }
    }
}