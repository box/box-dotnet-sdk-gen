using System.ComponentModel;
using Serializer;
using System.Text.Json.Serialization;

namespace Box.Schemas {
    [JsonConverter(typeof(StringEnumConverter<TimelineSkillCardTypeField>))]
    public enum TimelineSkillCardTypeField {
        [Description("skill_card")]
        SkillCard
    }
}