using System.ComponentModel;
using Serializer;
using System.Text.Json.Serialization;

namespace Box.Schemas {
    [JsonConverter(typeof(StringEnumConverter<TimelineSkillCardSkillFieldTypeField>))]
    public enum TimelineSkillCardSkillFieldTypeField {
        [Description("service")]
        Service
    }
}