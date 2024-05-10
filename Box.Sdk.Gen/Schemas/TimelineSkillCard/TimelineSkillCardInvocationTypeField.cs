using System.ComponentModel;
using Serializer;
using System.Text.Json.Serialization;

namespace Box.Sdk.Gen.Schemas {
    [JsonConverter(typeof(StringEnumConverter<TimelineSkillCardInvocationTypeField>))]
    public enum TimelineSkillCardInvocationTypeField {
        [Description("skill_invocation")]
        SkillInvocation
    }
}