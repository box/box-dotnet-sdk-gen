using System.ComponentModel;
using Serializer;
using System.Text.Json.Serialization;

namespace Box.Schemas {
    [JsonConverter(typeof(StringEnumConverter<SkillInvocationTypeField>))]
    public enum SkillInvocationTypeField {
        [Description("skill_invocation")]
        SkillInvocation
    }
}