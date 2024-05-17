using Unions;
using System.Text.Json.Serialization;

namespace Box.Sdk.Gen.Schemas {
    public class StatusSkillCardInvocationField {
        /// <summary>
        /// `skill_invocation`
        /// </summary>
        [JsonPropertyName("type")]
        public StatusSkillCardInvocationTypeField Type { get; }

        /// <summary>
        /// A custom identifier that represent the instance of
        /// the service that applied this metadata. For example,
        /// if your `image-recognition-service` runs on multiple
        /// nodes, this field can be used to identify the ID of
        /// the node that was used to apply the metadata.
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; }

        public StatusSkillCardInvocationField(string id, StatusSkillCardInvocationTypeField type = StatusSkillCardInvocationTypeField.SkillInvocation) {
            Type = type;
            Id = id;
        }
    }
}