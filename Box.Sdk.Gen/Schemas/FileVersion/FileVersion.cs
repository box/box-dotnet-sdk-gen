using Box.Sdk.Gen;
using System.Text.Json.Serialization;
using Box.Sdk.Gen.Schemas;

namespace Box.Sdk.Gen.Schemas {
    public class FileVersion : FileVersionMini {
        [JsonInclude]
        [JsonPropertyName("_istrashed_atSet")]
        protected bool _isTrashedAtSet { get; set; }

        [JsonInclude]
        [JsonPropertyName("_isrestored_atSet")]
        protected bool _isRestoredAtSet { get; set; }

        [JsonInclude]
        [JsonPropertyName("_ispurged_atSet")]
        protected bool _isPurgedAtSet { get; set; }

        protected System.DateTimeOffset? _trashedAt { get; set; }

        protected System.DateTimeOffset? _restoredAt { get; set; }

        protected System.DateTimeOffset? _purgedAt { get; set; }

        /// <summary>
        /// The name of the file version
        /// </summary>
        [JsonPropertyName("name")]
        public string? Name { get; init; }

        /// <summary>
        /// Size of the file version in bytes
        /// </summary>
        [JsonPropertyName("size")]
        public long? Size { get; init; }

        /// <summary>
        /// When the file version object was created
        /// </summary>
        [JsonPropertyName("created_at")]
        public System.DateTimeOffset? CreatedAt { get; init; }

        /// <summary>
        /// When the file version object was last updated
        /// </summary>
        [JsonPropertyName("modified_at")]
        public System.DateTimeOffset? ModifiedAt { get; init; }

        [JsonPropertyName("modified_by")]
        public UserMini? ModifiedBy { get; init; }

        /// <summary>
        /// When the file version object was trashed.
        /// </summary>
        [JsonPropertyName("trashed_at")]
        public System.DateTimeOffset? TrashedAt { get => _trashedAt; init { _trashedAt = value; _isTrashedAtSet = true; } }

        [JsonPropertyName("trashed_by")]
        public UserMini? TrashedBy { get; init; }

        /// <summary>
        /// When the file version was restored from the trash.
        /// </summary>
        [JsonPropertyName("restored_at")]
        public System.DateTimeOffset? RestoredAt { get => _restoredAt; init { _restoredAt = value; _isRestoredAtSet = true; } }

        [JsonPropertyName("restored_by")]
        public UserMini? RestoredBy { get; init; }

        /// <summary>
        /// When the file version object will be permanently deleted.
        /// </summary>
        [JsonPropertyName("purged_at")]
        public System.DateTimeOffset? PurgedAt { get => _purgedAt; init { _purgedAt = value; _isPurgedAtSet = true; } }

        [JsonPropertyName("uploader_display_name")]
        public string? UploaderDisplayName { get; init; }

        public FileVersion(string id, FileVersionBaseTypeField type = FileVersionBaseTypeField.FileVersion) : base(id, type) {
            
        }
        
        [JsonConstructorAttribute]
        internal FileVersion(string id, StringEnum<FileVersionBaseTypeField> type) : base(id, type ?? new StringEnum<FileVersionBaseTypeField>(FileVersionBaseTypeField.FileVersion)) {
            
        }
    }
}