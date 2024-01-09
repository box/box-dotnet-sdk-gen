using System.ComponentModel;
using Serializer;
using System.Text.Json.Serialization;

namespace Box.Schemas {
    [JsonConverter(typeof(StringEnumConverter<SkillInvocationTokenReadTokenTypeField>))]
    public enum SkillInvocationTokenReadTokenTypeField {
        [Description("bearer")]
        Bearer
    }
}