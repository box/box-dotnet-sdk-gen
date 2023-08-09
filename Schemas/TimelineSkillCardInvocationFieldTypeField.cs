using System.ComponentModel;
using Serializer;
using System.Text.Json.Serialization;

namespace Box.Schemas {
    [JsonConverter(typeof(StringEnumConverter<TimelineSkillCardInvocationFieldTypeField>))]
    public enum TimelineSkillCardInvocationFieldTypeField {
        [Description("skill_invocation")]
        SkillInvocation
    }
}