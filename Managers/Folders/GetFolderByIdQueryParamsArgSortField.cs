using System.ComponentModel;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public enum GetFolderByIdQueryParamsArgSortField {
        [Description("id")]
        Id,
        [Description("name")]
        Name,
        [Description("date")]
        Date,
        [Description("size")]
        Size
    }
}