using Unions;
using System.Text.Json.Serialization;

namespace Box.Sdk.Gen.Schemas {
    public class KeywordSkillCardSkillField {
        /// <summary>
        /// `service`
        /// </summary>
        [JsonPropertyName("type")]
        public KeywordSkillCardSkillTypeField Type { get; set; }

        /// <summary>
        /// A custom identifier that represent the service that
        /// applied this metadata.
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; }

        public KeywordSkillCardSkillField(string id, KeywordSkillCardSkillTypeField type = KeywordSkillCardSkillTypeField.Service) {
            Type = type;
            Id = id;
        }
    }
}