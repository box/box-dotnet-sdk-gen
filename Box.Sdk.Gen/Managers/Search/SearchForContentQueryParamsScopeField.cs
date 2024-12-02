using System.ComponentModel;
using Box.Sdk.Gen.Internal;
using Box.Sdk.Gen.Schemas;

namespace Box.Sdk.Gen.Managers {
    public enum SearchForContentQueryParamsScopeField {
        [Description("user_content")]
        UserContent,
        [Description("enterprise_content")]
        EnterpriseContent
    }
}