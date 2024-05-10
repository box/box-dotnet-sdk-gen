using System.ComponentModel;
using Serializer;
using System.Text.Json.Serialization;
using Box.Sdk.Gen.Schemas;

namespace Box.Sdk.Gen.Schemas {
    [JsonConverter(typeof(StringEnumConverter<FolderSharedLinkEffectivePermissionField>))]
    public enum FolderSharedLinkEffectivePermissionField {
        [Description("can_edit")]
        CanEdit,
        [Description("can_download")]
        CanDownload,
        [Description("can_preview")]
        CanPreview,
        [Description("no_access")]
        NoAccess
    }
}