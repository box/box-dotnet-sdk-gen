using System.ComponentModel;
using Serializer;
using System.Text.Json.Serialization;

namespace Box.Schemas {
    [JsonConverter(typeof(StringEnumConverter<ShieldInformationBarrierStatusField>))]
    public enum ShieldInformationBarrierStatusField {
        [Description("draft")]
        Draft,
        [Description("pending")]
        Pending,
        [Description("disabled")]
        Disabled,
        [Description("enabled")]
        Enabled,
        [Description("invalid")]
        Invalid
    }
}