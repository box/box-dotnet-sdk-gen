using System.ComponentModel;
using Serializer;
using System.Text.Json.Serialization;

namespace Box.Sdk.Gen.Schemas {
    [JsonConverter(typeof(StringEnumConverter<SkillInvocationSkillTypeField>))]
    public enum SkillInvocationSkillTypeField {
        [Description("skill")]
        Skill
    }
}