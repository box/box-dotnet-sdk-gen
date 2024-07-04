using Box.Sdk.Gen;
using System.Text.Json.Serialization;
using Box.Sdk.Gen.Internal;

namespace Box.Sdk.Gen.Schemas {
    public class KeywordSkillCardSkillField {
        /// <summary>
        /// `service`
        /// </summary>
        [JsonPropertyName("type")]
        [JsonConverter(typeof(StringEnumConverter<KeywordSkillCardSkillTypeField>))]
        public StringEnum<KeywordSkillCardSkillTypeField> Type { get; }

        /// <summary>
        /// A custom identifier that represent the service that
        /// applied this metadata.
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; }

        public KeywordSkillCardSkillField(string id, KeywordSkillCardSkillTypeField type = KeywordSkillCardSkillTypeField.Service) {
            Type = type;
            Id = id;
        }
        
        [JsonConstructorAttribute]
        internal KeywordSkillCardSkillField(string id, StringEnum<KeywordSkillCardSkillTypeField> type) {
            Type = KeywordSkillCardSkillTypeField.Service;
            Id = id;
        }
    }
}