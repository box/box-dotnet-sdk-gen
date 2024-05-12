using System.ComponentModel;
using Serializer;
using System.Text.Json.Serialization;

namespace Box.Sdk.Gen.Schemas {
    [JsonConverter(typeof(StringEnumConverter<StatusSkillCardSkillCardTypeField>))]
    public enum StatusSkillCardSkillCardTypeField {
        [Description("status")]
        Status
    }
}