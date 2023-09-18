using System.ComponentModel;
using Serializer;
using System.Text.Json.Serialization;

namespace Box.Schemas {
    [JsonConverter(typeof(StringEnumConverter<KeywordSkillCardSkillCardTypeField>))]
    public enum KeywordSkillCardSkillCardTypeField {
        [Description("keyword")]
        Keyword
    }
}