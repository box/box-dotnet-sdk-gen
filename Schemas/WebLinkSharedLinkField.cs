using System.IO;
using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;

namespace Box.Schemas {
    public class WebLinkSharedLinkField {
        [JsonPropertyName("url")]
        public string Url { get; }

        [JsonPropertyName("download_url")]
        public string DownloadUrl { get; }

        [JsonPropertyName("vanity_url")]
        public string VanityUrl { get; }

        [JsonPropertyName("vanity_name")]
        public string VanityName { get; }

        [JsonPropertyName("access")]
        public WebLinkSharedLinkFieldAccessField Access { get; }

        [JsonPropertyName("effective_access")]
        public WebLinkSharedLinkFieldEffectiveAccessField EffectiveAccess { get; }

        [JsonPropertyName("effective_permission")]
        public WebLinkSharedLinkFieldEffectivePermissionField EffectivePermission { get; }

        [JsonPropertyName("unshared_at")]
        public string UnsharedAt { get; }

        [JsonPropertyName("is_password_enabled")]
        public bool IsPasswordEnabled { get; }

        [JsonPropertyName("permissions")]
        public WebLinkSharedLinkFieldPermissionsField Permissions { get; }

        [JsonPropertyName("download_count")]
        public int DownloadCount { get; }

        [JsonPropertyName("preview_count")]
        public int PreviewCount { get; }

        public WebLinkSharedLinkField(string url, string downloadUrl, string vanityUrl, string vanityName, WebLinkSharedLinkFieldAccessField access, WebLinkSharedLinkFieldEffectiveAccessField effectiveAccess, WebLinkSharedLinkFieldEffectivePermissionField effectivePermission, string unsharedAt, bool isPasswordEnabled, WebLinkSharedLinkFieldPermissionsField permissions, int downloadCount, int previewCount) {
            Url = url;
            DownloadUrl = downloadUrl;
            VanityUrl = vanityUrl;
            VanityName = vanityName;
            Access = access;
            EffectiveAccess = effectiveAccess;
            EffectivePermission = effectivePermission;
            UnsharedAt = unsharedAt;
            IsPasswordEnabled = isPasswordEnabled;
            Permissions = permissions;
            DownloadCount = downloadCount;
            PreviewCount = previewCount;
        }
    }
}