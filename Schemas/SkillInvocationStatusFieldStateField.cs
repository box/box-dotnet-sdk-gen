using System.ComponentModel;
using Serializer;
using System.Text.Json.Serialization;

namespace Box.Schemas {
    [JsonConverter(typeof(StringEnumConverter<SkillInvocationStatusFieldStateField>))]
    public enum SkillInvocationStatusFieldStateField {
        [Description("invoked")]
        Invoked,
        [Description("processing")]
        Processing,
        [Description("success")]
        Success,
        [Description("transient_failure")]
        TransientFailure,
        [Description("permanent_failure")]
        PermanentFailure
    }
}