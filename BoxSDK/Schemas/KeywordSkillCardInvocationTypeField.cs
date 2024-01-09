using System.ComponentModel;
using Serializer;
using System.Text.Json.Serialization;

namespace Box.Schemas {
    [JsonConverter(typeof(StringEnumConverter<KeywordSkillCardInvocationTypeField>))]
    public enum KeywordSkillCardInvocationTypeField {
        [Description("skill_invocation")]
        SkillInvocation
    }
}