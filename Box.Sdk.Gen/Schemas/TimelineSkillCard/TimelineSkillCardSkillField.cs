using Unions;
using System.Text.Json.Serialization;
using Box.Sdk.Gen;
using Serializer;

namespace Box.Sdk.Gen.Schemas {
    public class TimelineSkillCardSkillField {
        /// <summary>
        /// `service`
        /// </summary>
        [JsonPropertyName("type")]
        [JsonConverter(typeof(StringEnumConverter<TimelineSkillCardSkillTypeField>))]
        public StringEnum<TimelineSkillCardSkillTypeField> Type { get; }

        /// <summary>
        /// A custom identifier that represent the service that
        /// applied this metadata.
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; }

        public TimelineSkillCardSkillField(string id, TimelineSkillCardSkillTypeField type = TimelineSkillCardSkillTypeField.Service) {
            Type = type;
            Id = id;
        }
        
        [JsonConstructorAttribute]
        internal TimelineSkillCardSkillField(string id, StringEnum<TimelineSkillCardSkillTypeField> type) {
            Type = TimelineSkillCardSkillTypeField.Service;
            Id = id;
        }
    }
}