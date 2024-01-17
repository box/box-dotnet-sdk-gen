using System.ComponentModel;
using Serializer;
using System.Text.Json.Serialization;

namespace Box.Sdk.Gen.Schemas {
    [JsonConverter(typeof(StringEnumConverter<TranscriptSkillCardSkillCardTypeField>))]
    public enum TranscriptSkillCardSkillCardTypeField {
        [Description("transcript")]
        Transcript
    }
}