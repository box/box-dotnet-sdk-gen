using Box.Sdk.Gen;
using System.Text.Json.Serialization;
using Box.Sdk.Gen.Internal;

namespace Box.Sdk.Gen.Schemas {
    public class TranscriptSkillCardInvocationField {
        /// <summary>
        /// `skill_invocation`
        /// </summary>
        [JsonPropertyName("type")]
        [JsonConverter(typeof(StringEnumConverter<TranscriptSkillCardInvocationTypeField>))]
        public StringEnum<TranscriptSkillCardInvocationTypeField> Type { get; }

        /// <summary>
        /// A custom identifier that represent the instance of
        /// the service that applied this metadata. For example,
        /// if your `image-recognition-service` runs on multiple
        /// nodes, this field can be used to identify the ID of
        /// the node that was used to apply the metadata.
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; }

        public TranscriptSkillCardInvocationField(string id, TranscriptSkillCardInvocationTypeField type = TranscriptSkillCardInvocationTypeField.SkillInvocation) {
            Type = type;
            Id = id;
        }
        
        [JsonConstructorAttribute]
        internal TranscriptSkillCardInvocationField(string id, StringEnum<TranscriptSkillCardInvocationTypeField> type) {
            Type = TranscriptSkillCardInvocationTypeField.SkillInvocation;
            Id = id;
        }
    }
}