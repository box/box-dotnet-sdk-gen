using System.ComponentModel;
using Serializer;
using System.Text.Json.Serialization;

namespace Box.Schemas {
    [JsonConverter(typeof(StringEnumConverter<TimelineSkillCardSkillCardTypeField>))]
    public enum TimelineSkillCardSkillCardTypeField {
        [Description("timeline")]
        Timeline
    }
}