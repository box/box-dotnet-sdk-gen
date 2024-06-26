using System.ComponentModel;
using Box.Sdk.Gen.Schemas;

namespace Box.Sdk.Gen.Schemas {
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