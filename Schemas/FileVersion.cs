using System.IO;
using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;

namespace Box.Schemas {
    public class FileVersion : FileVersionMini {
        [JsonPropertyName("name")]
        public string Name { get; }

        [JsonPropertyName("size")]
        public long? Size { get; }

        [JsonPropertyName("created_at")]
        public string CreatedAt { get; }

        [JsonPropertyName("modified_at")]
        public string ModifiedAt { get; }

        [JsonPropertyName("modified_by")]
        public UserMini ModifiedBy { get; }

        [JsonPropertyName("trashed_at")]
        public string TrashedAt { get; }

        [JsonPropertyName("trashed_by")]
        public UserMini TrashedBy { get; }

        [JsonPropertyName("restored_at")]
        public string RestoredAt { get; }

        [JsonPropertyName("restored_by")]
        public UserMini RestoredBy { get; }

        [JsonPropertyName("purged_at")]
        public string PurgedAt { get; }

        [JsonPropertyName("uploader_display_name")]
        public string UploaderDisplayName { get; }

        public FileVersion(string id, FileVersionBaseTypeField type, string sha1, string name, long? size, string createdAt, string modifiedAt, UserMini modifiedBy, string trashedAt, UserMini trashedBy, string restoredAt, UserMini restoredBy, string purgedAt, string uploaderDisplayName) : base(id, type, sha1) {
            Name = name;
            Size = size;
            CreatedAt = createdAt;
            ModifiedAt = modifiedAt;
            ModifiedBy = modifiedBy;
            TrashedAt = trashedAt;
            TrashedBy = trashedBy;
            RestoredAt = restoredAt;
            RestoredBy = restoredBy;
            PurgedAt = purgedAt;
            UploaderDisplayName = uploaderDisplayName;
        }
    }
}