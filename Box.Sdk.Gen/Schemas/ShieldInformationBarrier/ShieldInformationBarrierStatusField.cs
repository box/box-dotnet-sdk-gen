using System.ComponentModel;
using Serializer;
using System.Text.Json.Serialization;
using Box.Sdk.Gen.Schemas;

namespace Box.Sdk.Gen.Schemas {
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