using System.ComponentModel;
using Serializer;
using System.Text.Json.Serialization;

namespace Box.Schemas {
    [JsonConverter(typeof(StringEnumConverter<StatusSkillCardInvocationFieldTypeField>))]
    public enum StatusSkillCardInvocationFieldTypeField {
        [Description("skill_invocation")]
        SkillInvocation
    }
}