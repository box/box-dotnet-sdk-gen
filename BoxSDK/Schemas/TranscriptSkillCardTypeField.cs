using System.ComponentModel;
using Serializer;
using System.Text.Json.Serialization;

namespace Box.Schemas {
    [JsonConverter(typeof(StringEnumConverter<TranscriptSkillCardTypeField>))]
    public enum TranscriptSkillCardTypeField {
        [Description("skill_card")]
        SkillCard
    }
}