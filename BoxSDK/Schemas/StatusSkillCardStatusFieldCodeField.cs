using System.ComponentModel;
using Serializer;
using System.Text.Json.Serialization;

namespace Box.Schemas {
    [JsonConverter(typeof(StringEnumConverter<StatusSkillCardStatusFieldCodeField>))]
    public enum StatusSkillCardStatusFieldCodeField {
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