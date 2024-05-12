using System.ComponentModel;
using Serializer;
using System.Text.Json.Serialization;

namespace Box.Sdk.Gen.Schemas {
    [JsonConverter(typeof(StringEnumConverter<StatusSkillCardInvocationTypeField>))]
    public enum StatusSkillCardInvocationTypeField {
        [Description("skill_invocation")]
        SkillInvocation
    }
}