using System.ComponentModel;
using Serializer;
using System.Text.Json.Serialization;

namespace Box.Schemas {
    [JsonConverter(typeof(StringEnumConverter<SkillInvocationSkillTypeField>))]
    public enum SkillInvocationSkillTypeField {
        [Description("skill")]
        Skill
    }
}