using Unions;
using System.Text.Json.Serialization;

namespace Box.Sdk.Gen.Schemas {
    public class TranscriptSkillCardSkillField {
        /// <summary>
        /// `service`
        /// </summary>
        [JsonPropertyName("type")]
        public TranscriptSkillCardSkillTypeField Type { get; }

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
    }
}