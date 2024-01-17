using System.ComponentModel;
using Serializer;
using System.Text.Json.Serialization;

namespace Box.Sdk.Gen.Schemas {
    [JsonConverter(typeof(StringEnumConverter<WebLinkSharedLinkEffectivePermissionField>))]
    public enum WebLinkSharedLinkEffectivePermissionField {
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