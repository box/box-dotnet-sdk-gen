using System.ComponentModel;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public enum GetSearchQueryParamsArgSortField {
        [Description("modified_at")]
        ModifiedAt,
        [Description("relevance")]
        Relevance
    }
}