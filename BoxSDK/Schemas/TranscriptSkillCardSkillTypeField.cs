using System.ComponentModel;
using Serializer;
using System.Text.Json.Serialization;

namespace Box.Schemas {
    [JsonConverter(typeof(StringEnumConverter<TranscriptSkillCardSkillTypeField>))]
    public enum TranscriptSkillCardSkillTypeField {
        [Description("service")]
        Service
    }
}