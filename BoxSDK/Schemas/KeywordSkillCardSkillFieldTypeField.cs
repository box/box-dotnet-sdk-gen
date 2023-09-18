using System.ComponentModel;
using Serializer;
using System.Text.Json.Serialization;

namespace Box.Schemas {
    [JsonConverter(typeof(StringEnumConverter<KeywordSkillCardSkillFieldTypeField>))]
    public enum KeywordSkillCardSkillFieldTypeField {
        [Description("service")]
        Service
    }
}