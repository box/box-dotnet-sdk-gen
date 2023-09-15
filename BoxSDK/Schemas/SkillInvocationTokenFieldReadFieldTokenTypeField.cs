using System.ComponentModel;
using Serializer;
using System.Text.Json.Serialization;

namespace Box.Schemas {
    [JsonConverter(typeof(StringEnumConverter<SkillInvocationTokenFieldReadFieldTokenTypeField>))]
    public enum SkillInvocationTokenFieldReadFieldTokenTypeField {
        [Description("bearer")]
        Bearer
    }
}