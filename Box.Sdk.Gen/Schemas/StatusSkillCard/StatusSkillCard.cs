using Unions;
using System.Text.Json.Serialization;

namespace Box.Sdk.Gen.Schemas {
    public class StatusSkillCard {
        /// <summary>
        /// The optional date and time this card was created at.
        /// </summary>
        [JsonPropertyName("created_at")]
        public System.DateTimeOffset? CreatedAt { get; init; }

        /// <summary>
        /// `skill_card`
        /// </summary>
        [JsonPropertyName("type")]
        public StatusSkillCardTypeField Type { get; }

        /// <summary>
        /// `status`
        /// </summary>
        [JsonPropertyName("skill_card_type")]
        public StatusSkillCardSkillCardTypeField SkillCardType { get; }

        /// <summary>
        /// The title of the card.
        /// </summary>
        [JsonPropertyName("skill_card_title")]
        public StatusSkillCardSkillCardTitleField? SkillCardTitle { get; init; }

        /// <summary>
        /// Sets the status of the skill. This can be used to show a message to the user while the Skill is processing the data, or if it was not able to process the file.
        /// </summary>
        [JsonPropertyName("status")]
        public StatusSkillCardStatusField Status { get; }

        /// <summary>
        /// The service that applied this metadata.
        /// </summary>
        [JsonPropertyName("skill")]
        public StatusSkillCardSkillField Skill { get; }

        /// <summary>
        /// The invocation of this service, used to track
        /// which instance of a service applied the metadata.
        /// </summary>
        [JsonPropertyName("invocation")]
        public StatusSkillCardInvocationField Invocation { get; }

        public StatusSkillCard(StatusSkillCardStatusField status, StatusSkillCardSkillField skill, StatusSkillCardInvocationField invocation, StatusSkillCardTypeField type = StatusSkillCardTypeField.SkillCard, StatusSkillCardSkillCardTypeField skillCardType = StatusSkillCardSkillCardTypeField.Status) {
            Type = type;
            SkillCardType = skillCardType;
            Status = status;
            Skill = skill;
            Invocation = invocation;
        }
    }
}