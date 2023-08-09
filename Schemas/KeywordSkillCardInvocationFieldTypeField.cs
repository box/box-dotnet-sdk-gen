using System.ComponentModel;
using Serializer;
using System.Text.Json.Serialization;

namespace Box.Schemas {
    [JsonConverter(typeof(StringEnumConverter<KeywordSkillCardInvocationFieldTypeField>))]
    public enum KeywordSkillCardInvocationFieldTypeField {
        [Description("skill_invocation")]
        SkillInvocation
    }
}