using Box.Sdk.Gen;
using System.Text.Json.Serialization;
using Box.Sdk.Gen.Internal;

namespace Box.Sdk.Gen.Schemas {
    public class StatusSkillCardSkillField {
        /// <summary>
        /// `service`
        /// </summary>
        [JsonPropertyName("type")]
        [JsonConverter(typeof(StringEnumConverter<StatusSkillCardSkillTypeField>))]
        public StringEnum<StatusSkillCardSkillTypeField> Type { get; }

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
        
        [JsonConstructorAttribute]
        internal StatusSkillCardSkillField(string id, StringEnum<StatusSkillCardSkillTypeField> type) {
            Type = StatusSkillCardSkillTypeField.Service;
            Id = id;
        }
    }
}