using System.ComponentModel;
using Serializer;
using System.Text.Json.Serialization;

namespace Box.Sdk.Gen.Schemas {
    [JsonConverter(typeof(StringEnumConverter<KeywordSkillCardSkillTypeField>))]
    public enum KeywordSkillCardSkillTypeField {
        [Description("service")]
        Service
    }
}