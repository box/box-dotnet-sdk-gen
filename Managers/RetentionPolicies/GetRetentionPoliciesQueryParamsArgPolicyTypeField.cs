using System.ComponentModel;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public enum GetRetentionPoliciesQueryParamsArgPolicyTypeField {
        [Description("finite")]
        Finite,
        [Description("indefinite")]
        Indefinite
    }
}