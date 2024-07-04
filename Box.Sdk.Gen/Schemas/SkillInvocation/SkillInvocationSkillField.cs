using Box.Sdk.Gen;
using System.Text.Json.Serialization;
using Box.Sdk.Gen.Internal;
using Box.Sdk.Gen.Schemas;

namespace Box.Sdk.Gen.Schemas {
    public class SkillInvocationSkillField {
        /// <summary>
        /// The unique identifier for this skill
        /// </summary>
        [JsonPropertyName("id")]
        public string? Id { get; init; }

        /// <summary>
        /// `skill`
        /// </summary>
        [JsonPropertyName("type")]
        [JsonConverter(typeof(StringEnumConverter<SkillInvocationSkillTypeField>))]
        public StringEnum<SkillInvocationSkillTypeField>? Type { get; init; }

        /// <summary>
        /// The name of the skill
        /// </summary>
        [JsonPropertyName("name")]
        public string? Name { get; init; }

        /// <summary>
        /// The client ID of the application
        /// </summary>
        [JsonPropertyName("api_key")]
        public string? ApiKey { get; init; }

        public SkillInvocationSkillField() {
            
        }
    }
}