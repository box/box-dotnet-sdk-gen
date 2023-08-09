using System.IO;
using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text.Json.Serialization;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class UpdateFileByIdRequestBodyArgLockField {
        [JsonPropertyName("access")]
        public UpdateFileByIdRequestBodyArgLockFieldAccessField Access { get; }

        [JsonPropertyName("expires_at")]
        public string ExpiresAt { get; }

        [JsonPropertyName("is_download_prevented")]
        public bool? IsDownloadPrevented { get; }

        public UpdateFileByIdRequestBodyArgLockField(UpdateFileByIdRequestBodyArgLockFieldAccessField access, string expiresAt, bool? isDownloadPrevented) {
            Access = access;
            ExpiresAt = expiresAt;
            IsDownloadPrevented = isDownloadPrevented;
        }
    }
}