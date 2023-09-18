using System.ComponentModel;
using Serializer;
using System.Text.Json.Serialization;

namespace Box.Schemas {
    [JsonConverter(typeof(StringEnumConverter<SkillInvocationSkillFieldTypeField>))]
    public enum SkillInvocationSkillFieldTypeField {
        [Description("skill")]
        Skill
    }
}