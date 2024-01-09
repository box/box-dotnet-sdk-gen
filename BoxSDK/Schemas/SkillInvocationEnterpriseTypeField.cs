using System.ComponentModel;
using Serializer;
using System.Text.Json.Serialization;

namespace Box.Schemas {
    [JsonConverter(typeof(StringEnumConverter<SkillInvocationEnterpriseTypeField>))]
    public enum SkillInvocationEnterpriseTypeField {
        [Description("enterprise")]
        Enterprise
    }
}