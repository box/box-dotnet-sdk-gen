using System.ComponentModel;
using Serializer;
using System.Text.Json.Serialization;

namespace Box.Schemas {
    [JsonConverter(typeof(StringEnumConverter<FileSharedLinkFieldEffectivePermissionField>))]
    public enum FileSharedLinkFieldEffectivePermissionField {
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