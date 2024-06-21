using System.ComponentModel;
using Box.Sdk.Gen.Schemas;

namespace Box.Sdk.Gen.Schemas {
    public enum FileFullSharedLinkPermissionOptionsField {
        [Description("can_preview")]
        CanPreview,
        [Description("can_download")]
        CanDownload,
        [Description("can_edit")]
        CanEdit
    }
}