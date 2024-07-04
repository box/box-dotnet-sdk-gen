using System.ComponentModel;
using Box.Sdk.Gen.Schemas;
using Box.Sdk.Gen.Internal;

namespace Box.Sdk.Gen.Managers {
    public enum CreateTermsOfServiceRequestBodyTosTypeField {
        [Description("external")]
        External,
        [Description("managed")]
        Managed
    }
}