using System.ComponentModel;
using Box.Sdk.Gen.Internal;
using Box.Sdk.Gen.Schemas;

namespace Box.Sdk.Gen.Managers {
    public enum SearchForContentQueryParamsSortField {
        [Description("modified_at")]
        ModifiedAt,
        [Description("relevance")]
        Relevance
    }
}