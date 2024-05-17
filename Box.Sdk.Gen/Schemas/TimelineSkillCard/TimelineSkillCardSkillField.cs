using Unions;
using System.Text.Json.Serialization;

namespace Box.Sdk.Gen.Schemas {
    public class TimelineSkillCardSkillField {
        /// <summary>
        /// `service`
        /// </summary>
        [JsonPropertyName("type")]
        public TimelineSkillCardSkillTypeField Type { get; }

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
    }
}