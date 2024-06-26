using System.ComponentModel;
using Box.Sdk.Gen.Schemas;

namespace Box.Sdk.Gen.Schemas {
    public enum RetentionPolicyStatusField {
        [Description("active")]
        Active,
        [Description("retired")]
        Retired
    }
}