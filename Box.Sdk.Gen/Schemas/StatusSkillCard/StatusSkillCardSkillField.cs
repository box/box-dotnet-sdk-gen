using Unions;
using System.Text.Json.Serialization;

namespace Box.Sdk.Gen.Schemas {
    public class StatusSkillCardSkillField {
        /// <summary>
        /// `service`
        /// </summary>
        [JsonPropertyName("type")]
        public StatusSkillCardSkillTypeField Type { get; }

        /// <summary>
        /// A custom identifier that represent the service that
        /// applied this metadata.
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; }

        public StatusSkillCardSkillField(string id, StatusSkillCardSkillTypeField type = StatusSkillCardSkillTypeField.Service) {
            Type = type;
            Id = id;
        }
    }
}