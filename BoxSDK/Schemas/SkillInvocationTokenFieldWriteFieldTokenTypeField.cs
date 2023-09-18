using System.ComponentModel;
using Serializer;
using System.Text.Json.Serialization;

namespace Box.Schemas {
    [JsonConverter(typeof(StringEnumConverter<SkillInvocationTokenFieldWriteFieldTokenTypeField>))]
    public enum SkillInvocationTokenFieldWriteFieldTokenTypeField {
        [Description("bearer")]
        Bearer
    }
}