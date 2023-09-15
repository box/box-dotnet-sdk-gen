using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Text.Json;

namespace Box.Schemas {
    public class Folder : FolderMini {
        /// <summary>
        /// The date and time when the folder was created. This value may
        /// be `null` for some folders such as the root folder or the trash
        /// folder.
        /// </summary>
        [JsonPropertyName("created_at")]
        public string? CreatedAt { get; set; } = default;

        /// <summary>
        /// The date and time when the folder was last updated. This value may
        /// be `null` for some folders such as the root folder or the trash
        /// folder.
        /// </summary>
        [JsonPropertyName("modified_at")]
        public string? ModifiedAt { get; set; } = default;

        [JsonPropertyName("description")]
        public string? Description { get; set; } = default;

        /// <summary>
        /// The folder size in bytes.
        /// 
        /// Be careful parsing this integer as its
        /// value can get very large.
        /// </summary>
        [JsonPropertyName("size")]
        public long? Size { get; set; } = default;

        [JsonPropertyName("path_collection")]
        public FolderPathCollectionField? PathCollection { get; set; } = default;

        [JsonPropertyName("created_by")]
        public UserMini? CreatedBy { get; set; } = default;

        [JsonPropertyName("modified_by")]
        public UserMini? ModifiedBy { get; set; } = default;

        /// <summary>
        /// The time at which this folder was put in the trash.
        /// </summary>
        [JsonPropertyName("trashed_at")]
        public string? TrashedAt { get; set; } = default;

        /// <summary>
        /// The time at which this folder is expected to be purged
        /// from the trash.
        /// </summary>
        [JsonPropertyName("purged_at")]
        public string? PurgedAt { get; set; } = default;

        /// <summary>
        /// The date and time at which this folder was originally
        /// created.
        /// </summary>
        [JsonPropertyName("content_created_at")]
        public string? ContentCreatedAt { get; set; } = default;

        /// <summary>
        /// The date and time at which this folder was last updated.
        /// </summary>
        [JsonPropertyName("content_modified_at")]
        public string? ContentModifiedAt { get; set; } = default;

        [JsonPropertyName("owned_by")]
        public UserMini? OwnedBy { get; set; } = default;

        [JsonPropertyName("shared_link")]
        public FolderSharedLinkField? SharedLink { get; set; } = default;

        [JsonPropertyName("folder_upload_email")]
        public FolderFolderUploadEmailField? FolderUploadEmail { get; set; } = default;

        [JsonPropertyName("parent")]
        public FolderMini? Parent { get; set; } = default;

        /// <summary>
        /// Defines if this item has been deleted or not.
        /// 
        /// * `active` when the item has is not in the trash
        /// * `trashed` when the item has been moved to the trash but not deleted
        /// * `deleted` when the item has been permanently deleted.
        /// </summary>
        [JsonPropertyName("item_status")]
        public FolderItemStatusField? ItemStatus { get; set; } = default;

        [JsonPropertyName("item_collection")]
        public Items? ItemCollection { get; set; } = default;

        public Folder(string id, FolderBaseTypeField type) : base(id, type) {
            
        }
    }
}