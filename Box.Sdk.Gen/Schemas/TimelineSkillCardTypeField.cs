using System.ComponentModel;
using Serializer;
using System.Text.Json.Serialization;

namespace Box.Sdk.Gen.Schemas {
    [JsonConverter(typeof(StringEnumConverter<TimelineSkillCardTypeField>))]
    public enum TimelineSkillCardTypeField {
        [Description("skill_card")]
        SkillCard
    }
}