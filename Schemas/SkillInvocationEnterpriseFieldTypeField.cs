using System.ComponentModel;
using Serializer;
using System.Text.Json.Serialization;

namespace Box.Schemas {
    [JsonConverter(typeof(StringEnumConverter<SkillInvocationEnterpriseFieldTypeField>))]
    public enum SkillInvocationEnterpriseFieldTypeField {
        [Description("enterprise")]
        Enterprise
    }
}