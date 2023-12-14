using System.ComponentModel;
using Serializer;
using System.Text.Json.Serialization;

namespace Box.Schemas {
    [JsonConverter(typeof(StringEnumConverter<SkillInvocationTokenWriteTokenTypeField>))]
    public enum SkillInvocationTokenWriteTokenTypeField {
        [Description("bearer")]
        Bearer
    }
}