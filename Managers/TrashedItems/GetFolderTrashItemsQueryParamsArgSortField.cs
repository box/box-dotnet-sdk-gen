using System.ComponentModel;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public enum GetFolderTrashItemsQueryParamsArgSortField {
        [Description("name")]
        Name,
        [Description("date")]
        Date,
        [Description("size")]
        Size
    }
}