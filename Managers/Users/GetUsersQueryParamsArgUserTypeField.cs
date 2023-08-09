using System.ComponentModel;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public enum GetUsersQueryParamsArgUserTypeField {
        [Description("all")]
        All,
        [Description("managed")]
        Managed,
        [Description("external")]
        External
    }
}