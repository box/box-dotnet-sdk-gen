using System.ComponentModel;
using Serializer;
using System.Text.Json.Serialization;

namespace Box.Schemas {
    [JsonConverter(typeof(StringEnumConverter<TranscriptSkillCardInvocationTypeField>))]
    public enum TranscriptSkillCardInvocationTypeField {
        [Description("skill_invocation")]
        SkillInvocation
    }
}