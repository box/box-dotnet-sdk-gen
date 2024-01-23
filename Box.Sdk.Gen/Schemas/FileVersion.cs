using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Text.Json;

namespace Box.Sdk.Gen.Schemas {
    public class FileVersion : FileVersionMini {
        /// <summary>
        /// The name of the file version
        /// </summary>
        [JsonPropertyName("name")]
        public string? Name { get; set; } = default;

        /// <summary>
        /// Size of the file version in bytes
        /// </summary>
        [JsonPropertyName("size")]
        public long? Size { get; set; } = default;

        /// <summary>
        /// When the file version object was created
        /// </summary>
        [JsonPropertyName("created_at")]
        public System.DateTimeOffset? CreatedAt { get; set; } = default;

        /// <summary>
        /// When the file version object was last updated
        /// </summary>
        [JsonPropertyName("modified_at")]
        public System.DateTimeOffset? ModifiedAt { get; set; } = default;

        [JsonPropertyName("modified_by")]
        public UserMini? ModifiedBy { get; set; } = default;

        /// <summary>
        /// When the file version object was trashed.
        /// </summary>
        [JsonPropertyName("trashed_at")]
        public System.DateTimeOffset? TrashedAt { get; set; } = default;

        [JsonPropertyName("trashed_by")]
        public UserMini? TrashedBy { get; set; } = default;

        /// <summary>
        /// When the file version was restored from the trash.
        /// </summary>
        [JsonPropertyName("restored_at")]
        public System.DateTimeOffset? RestoredAt { get; set; } = default;

        [JsonPropertyName("restored_by")]
        public UserMini? RestoredBy { get; set; } = default;

        /// <summary>
        /// When the file version object will be permanently deleted.
        /// </summary>
        [JsonPropertyName("purged_at")]
        public System.DateTimeOffset? PurgedAt { get; set; } = default;

        [JsonPropertyName("uploader_display_name")]
        public string? UploaderDisplayName { get; set; } = default;

        public FileVersion(string id, FileVersionBaseTypeField type) : base(id, type) {
            
        }
    }
}