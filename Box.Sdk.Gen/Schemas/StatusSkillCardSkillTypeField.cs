using System.ComponentModel;
using Serializer;
using System.Text.Json.Serialization;

namespace Box.Sdk.Gen.Schemas {
    [JsonConverter(typeof(StringEnumConverter<StatusSkillCardSkillTypeField>))]
    public enum StatusSkillCardSkillTypeField {
        [Description("service")]
        Service
    }
}