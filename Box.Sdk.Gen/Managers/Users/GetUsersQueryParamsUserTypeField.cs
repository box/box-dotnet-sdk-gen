using System.ComponentModel;
using Box.Sdk.Gen.Schemas;
using Box.Sdk.Gen.Internal;

namespace Box.Sdk.Gen.Managers {
    public enum GetUsersQueryParamsUserTypeField {
        [Description("all")]
        All,
        [Description("managed")]
        Managed,
        [Description("external")]
        External
    }
}