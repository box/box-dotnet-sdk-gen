using System.ComponentModel;
using Serializer;
using System.Text.Json.Serialization;

namespace Box.Schemas {
    [JsonConverter(typeof(StringEnumConverter<TimelineSkillCardSkillTypeField>))]
    public enum TimelineSkillCardSkillTypeField {
        [Description("service")]
        Service
    }
}