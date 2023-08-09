using System.ComponentModel;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public enum GetSearchQueryParamsArgTypeField {
        [Description("file")]
        File,
        [Description("folder")]
        Folder,
        [Description("web_link")]
        WebLink
    }
}