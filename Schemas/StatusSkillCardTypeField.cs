using System.ComponentModel;
using Serializer;
using System.Text.Json.Serialization;

namespace Box.Schemas {
    [JsonConverter(typeof(StringEnumConverter<StatusSkillCardTypeField>))]
    public enum StatusSkillCardTypeField {
        [Description("skill_card")]
        SkillCard
    }
}