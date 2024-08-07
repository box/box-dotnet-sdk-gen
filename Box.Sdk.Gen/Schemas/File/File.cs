using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Box.Sdk.Gen;
using Box.Sdk.Gen.Internal;
using Box.Sdk.Gen.Schemas;

namespace Box.Sdk.Gen.Schemas {
    public class File : FileMini {
        /// <summary>
        /// The optional description of this file.
        /// If the description exceeds 255 characters, the first 255 characters
        /// are set as a file description and the rest of it is ignored.
        /// </summary>
        [JsonPropertyName("description")]
        public string? Description { get; init; }

        /// <summary>
        /// The file size in bytes. Be careful parsing this integer as it can
        /// get very large and cause an integer overflow.
        /// </summary>
        [JsonPropertyName("size")]
        public long? Size { get; init; }

        [JsonPropertyName("path_collection")]
        public FilePathCollectionField? PathCollection { get; init; }

        /// <summary>
        /// The date and time when the file was created on Box.
        /// </summary>
        [JsonPropertyName("created_at")]
        public System.DateTimeOffset? CreatedAt { get; init; }

        /// <summary>
        /// The date and time when the file was last updated on Box.
        /// </summary>
        [JsonPropertyName("modified_at")]
        public System.DateTimeOffset? ModifiedAt { get; init; }

        /// <summary>
        /// The time at which this file was put in the trash.
        /// </summary>
        [JsonPropertyName("trashed_at")]
        public System.DateTimeOffset? TrashedAt { get; init; }

        /// <summary>
        /// The time at which this file is expected to be purged
        /// from the trash.
        /// </summary>
        [JsonPropertyName("purged_at")]
        public System.DateTimeOffset? PurgedAt { get; init; }

        /// <summary>
        /// The date and time at which this file was originally
        /// created, which might be before it was uploaded to Box.
        /// </summary>
        [JsonPropertyName("content_created_at")]
        public System.DateTimeOffset? ContentCreatedAt { get; init; }

        /// <summary>
        /// The date and time at which this file was last updated,
        /// which might be before it was uploaded to Box.
        /// </summary>
        [JsonPropertyName("content_modified_at")]
        public System.DateTimeOffset? ContentModifiedAt { get; init; }

        [JsonPropertyName("created_by")]
        public UserMini? CreatedBy { get; init; }

        [JsonPropertyName("modified_by")]
        public UserMini? ModifiedBy { get; init; }

        [JsonPropertyName("owned_by")]
        public UserMini? OwnedBy { get; init; }

        [JsonPropertyName("shared_link")]
        public FileSharedLinkField? SharedLink { get; init; }

        [JsonPropertyName("parent")]
        public FolderMini? Parent { get; init; }

        /// <summary>
        /// Defines if this item has been deleted or not.
        /// 
        /// * `active` when the item has is not in the trash
        /// * `trashed` when the item has been moved to the trash but not deleted
        /// * `deleted` when the item has been permanently deleted.
        /// </summary>
        [JsonPropertyName("item_status")]
        [JsonConverter(typeof(StringEnumConverter<FileItemStatusField>))]
        public StringEnum<FileItemStatusField>? ItemStatus { get; init; }

        public File(string id, FileBaseTypeField type = FileBaseTypeField.File) : base(id, type) {
            
        }
        
        [JsonConstructorAttribute]
        internal File(string id, StringEnum<FileBaseTypeField> type) : base(id, type ?? new StringEnum<FileBaseTypeField>(FileBaseTypeField.File)) {
            
        }
    }
}