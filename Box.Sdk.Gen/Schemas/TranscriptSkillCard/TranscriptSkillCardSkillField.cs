using Box.Sdk.Gen;
using System.Text.Json.Serialization;
using Box.Sdk.Gen.Internal;

namespace Box.Sdk.Gen.Schemas {
    public class TranscriptSkillCardSkillField {
        /// <summary>
        /// `service`
        /// </summary>
        [JsonPropertyName("type")]
        [JsonConverter(typeof(StringEnumConverter<TranscriptSkillCardSkillTypeField>))]
        public StringEnum<TranscriptSkillCardSkillTypeField> Type { get; }

        /// <summary>
        /// A custom identifier that represent the service that
        /// applied this metadata.
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; }

        public TranscriptSkillCardSkillField(string id, TranscriptSkillCardSkillTypeField type = TranscriptSkillCardSkillTypeField.Service) {
            Type = type;
            Id = id;
        }
        
        [JsonConstructorAttribute]
        internal TranscriptSkillCardSkillField(string id, StringEnum<TranscriptSkillCardSkillTypeField> type) {
            Type = TranscriptSkillCardSkillTypeField.Service;
            Id = id;
        }
    }
}