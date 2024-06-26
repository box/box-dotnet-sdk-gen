using Unions;
using System.Text.Json.Serialization;
using Box.Sdk.Gen.Schemas;

namespace Box.Sdk.Gen.Schemas {
    public class FileVersion : FileVersionMini {
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
        public System.DateTimeOffset? TrashedAt { get; init; }

        [JsonPropertyName("trashed_by")]
        public UserMini? TrashedBy { get; init; }

        /// <summary>
        /// When the file version was restored from the trash.
        /// </summary>
        [JsonPropertyName("restored_at")]
        public System.DateTimeOffset? RestoredAt { get; init; }

        [JsonPropertyName("restored_by")]
        public UserMini? RestoredBy { get; init; }

        /// <summary>
        /// When the file version object will be permanently deleted.
        /// </summary>
        [JsonPropertyName("purged_at")]
        public System.DateTimeOffset? PurgedAt { get; init; }

        [JsonPropertyName("uploader_display_name")]
        public string? UploaderDisplayName { get; init; }

        public FileVersion(string id, FileVersionBaseTypeField type = FileVersionBaseTypeField.FileVersion) : base(id, type) {
            
        }
        
        [JsonConstructorAttribute]
        internal FileVersion(string id, StringEnum<FileVersionBaseTypeField> type) : base(id, type ?? new StringEnum<FileVersionBaseTypeField>(FileVersionBaseTypeField.FileVersion)) {
            
        }
    }
}