using System.ComponentModel;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public enum GetSearchQueryParamsArgScopeField {
        [Description("user_content")]
        UserContent,
        [Description("enterprise_content")]
        EnterpriseContent
    }
}