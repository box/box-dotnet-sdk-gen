using System.ComponentModel;
using Serializer;
using System.Text.Json.Serialization;

namespace Box.Schemas {
    [JsonConverter(typeof(StringEnumConverter<KeywordSkillCardTypeField>))]
    public enum KeywordSkillCardTypeField {
        [Description("skill_card")]
        SkillCard
    }
}