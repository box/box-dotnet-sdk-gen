using System.ComponentModel;
using Serializer;
using System.Text.Json.Serialization;

namespace Box.Schemas {
    [JsonConverter(typeof(StringEnumConverter<TranscriptSkillCardInvocationFieldTypeField>))]
    public enum TranscriptSkillCardInvocationFieldTypeField {
        [Description("skill_invocation")]
        SkillInvocation
    }
}