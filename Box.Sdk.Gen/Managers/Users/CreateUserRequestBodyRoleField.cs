using System.ComponentModel;
using Box.Sdk.Gen.Schemas;
using Box.Sdk.Gen;

namespace Box.Sdk.Gen.Managers {
    public enum CreateUserRequestBodyRoleField {
        [Description("coadmin")]
        Coadmin,
        [Description("user")]
        User
    }
}