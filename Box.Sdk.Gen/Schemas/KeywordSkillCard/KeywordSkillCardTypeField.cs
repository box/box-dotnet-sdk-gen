using System.ComponentModel;
using Serializer;
using System.Text.Json.Serialization;

namespace Box.Sdk.Gen.Schemas {
    [JsonConverter(typeof(StringEnumConverter<KeywordSkillCardTypeField>))]
    public enum KeywordSkillCardTypeField {
        [Description("skill_card")]
        SkillCard
    }
}