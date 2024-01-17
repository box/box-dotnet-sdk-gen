using System.ComponentModel;
using Serializer;
using System.Text.Json.Serialization;

namespace Box.Sdk.Gen.Schemas {
    [JsonConverter(typeof(StringEnumConverter<FileFullSharedLinkPermissionOptionsField>))]
    public enum FileFullSharedLinkPermissionOptionsField {
        [Description("can_preview")]
        CanPreview,
        [Description("can_download")]
        CanDownload,
        [Description("can_edit")]
        CanEdit
    }
}