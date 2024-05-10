using System.ComponentModel;
using Serializer;
using System.Text.Json.Serialization;

namespace Box.Sdk.Gen.Schemas {
    [JsonConverter(typeof(StringEnumConverter<StatusSkillCardTypeField>))]
    public enum StatusSkillCardTypeField {
        [Description("skill_card")]
        SkillCard
    }
}