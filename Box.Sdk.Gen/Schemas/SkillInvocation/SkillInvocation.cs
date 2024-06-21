using Unions;
using Box.Sdk.Gen;
using System.Text.Json.Serialization;
using Serializer;
using Box.Sdk.Gen.Schemas;

namespace Box.Sdk.Gen.Schemas {
    public class SkillInvocation {
        /// <summary>
        /// `skill_invocation`
        /// </summary>
        [JsonPropertyName("type")]
        [JsonConverter(typeof(StringEnumConverter<SkillInvocationTypeField>))]
        public StringEnum<SkillInvocationTypeField>? Type { get; init; }

        /// <summary>
        /// Unique identifier for the invocation request.
        /// </summary>
        [JsonPropertyName("id")]
        public string? Id { get; init; }

        [JsonPropertyName("skill")]
        public SkillInvocationSkillField? Skill { get; init; }

        /// <summary>
        /// The read-only and read-write access tokens for this item
        /// </summary>
        [JsonPropertyName("token")]
        public SkillInvocationTokenField? Token { get; init; }

        /// <summary>
        /// The details status of this event.
        /// </summary>
        [JsonPropertyName("status")]
        public SkillInvocationStatusField? Status { get; init; }

        /// <summary>
        /// The time this invocation was created.
        /// </summary>
        [JsonPropertyName("created_at")]
        public System.DateTimeOffset? CreatedAt { get; init; }

        /// <summary>
        /// Action that triggered the invocation
        /// </summary>
        [JsonPropertyName("trigger")]
        public string? Trigger { get; init; }

        [JsonPropertyName("enterprise")]
        public SkillInvocationEnterpriseField? Enterprise { get; init; }

        [JsonPropertyName("source")]
        public FileOrFolder? Source { get; init; }

        [JsonPropertyName("event")]
        public Event? Event { get; init; }

        public SkillInvocation() {
            
        }
    }
}