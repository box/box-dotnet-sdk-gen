using System.ComponentModel;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public enum GetTermOfServicesQueryParamsArgTosTypeField {
        [Description("external")]
        External,
        [Description("managed")]
        Managed
    }
}