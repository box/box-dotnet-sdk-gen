using System.ComponentModel;
using Serializer;
using System.Text.Json.Serialization;

namespace Box.Schemas {
    [JsonConverter(typeof(StringEnumConverter<StatusSkillCardSkillTypeField>))]
    public enum StatusSkillCardSkillTypeField {
        [Description("service")]
        Service
    }
}