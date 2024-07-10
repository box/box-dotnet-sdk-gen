using Box.Sdk.Gen;
using System.Text.Json.Serialization;
using Box.Sdk.Gen.Internal;

namespace Box.Sdk.Gen.Schemas {
    public class StatusSkillCardInvocationField {
        /// <summary>
        /// `skill_invocation`
        /// </summary>
        [JsonPropertyName("type")]
        [JsonConverter(typeof(StringEnumConverter<StatusSkillCardInvocationTypeField>))]
        public StringEnum<StatusSkillCardInvocationTypeField> Type { get; }

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
        
        [JsonConstructorAttribute]
        internal StatusSkillCardInvocationField(string id, StringEnum<StatusSkillCardInvocationTypeField> type) {
            Type = StatusSkillCardInvocationTypeField.SkillInvocation;
            Id = id;
        }
    }
}