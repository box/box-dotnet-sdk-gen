using System.ComponentModel;
using Serializer;
using System.Text.Json.Serialization;

namespace Box.Schemas {
    [JsonConverter(typeof(StringEnumConverter<TranscriptSkillCardSkillFieldTypeField>))]
    public enum TranscriptSkillCardSkillFieldTypeField {
        [Description("service")]
        Service
    }
}