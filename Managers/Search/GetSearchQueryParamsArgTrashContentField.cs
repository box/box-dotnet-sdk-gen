using System.ComponentModel;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public enum GetSearchQueryParamsArgTrashContentField {
        [Description("non_trashed_only")]
        NonTrashedOnly,
        [Description("trashed_only")]
        TrashedOnly,
        [Description("all_items")]
        AllItems
    }
}