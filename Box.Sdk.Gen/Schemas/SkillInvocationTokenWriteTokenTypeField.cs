using System.ComponentModel;
using Serializer;
using System.Text.Json.Serialization;

namespace Box.Sdk.Gen.Schemas {
    [JsonConverter(typeof(StringEnumConverter<SkillInvocationTokenWriteTokenTypeField>))]
    public enum SkillInvocationTokenWriteTokenTypeField {
        [Description("bearer")]
        Bearer
    }
}