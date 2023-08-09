using System.IO;
using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;

namespace Box.Schemas {
    public class FileFullLockField {
        [JsonPropertyName("id")]
        public string Id { get; }

        [JsonPropertyName("type")]
        public FileFullLockFieldTypeField Type { get; }

        [JsonPropertyName("created_by")]
        public UserMini CreatedBy { get; }

        [JsonPropertyName("created_at")]
        public string CreatedAt { get; }

        [JsonPropertyName("expired_at")]
        public string ExpiredAt { get; }

        [JsonPropertyName("is_download_prevented")]
        public bool? IsDownloadPrevented { get; }

        [JsonPropertyName("app_type")]
        public FileFullLockFieldAppTypeField AppType { get; }

        public FileFullLockField(string id, FileFullLockFieldTypeField type, UserMini createdBy, string createdAt, string expiredAt, bool? isDownloadPrevented, FileFullLockFieldAppTypeField appType) {
            Id = id;
            Type = type;
            CreatedBy = createdBy;
            CreatedAt = createdAt;
            ExpiredAt = expiredAt;
            IsDownloadPrevented = isDownloadPrevented;
            AppType = appType;
        }
    }
}