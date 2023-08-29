using System.IO;
using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;

namespace Box.Schemas {
    public class TrashFolder {
        /// <summary>
        /// The unique identifier that represent a folder.
        /// 
        /// The ID for any folder can be determined
        /// by visiting a folder in the web application
        /// and copying the ID from the URL. For example,
        /// for the URL `https://*.app.box.com/folders/123`
        /// the `folder_id` is `123`.
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; }

        /// <summary>
        /// The HTTP `etag` of this folder. This can be used within some API
        /// endpoints in the `If-Match` and `If-None-Match` headers to only
        /// perform changes on the folder if (no) changes have happened.
        /// </summary>
        [JsonPropertyName("etag")]
        public string? Etag { get; set; } = default;

        /// <summary>
        /// `folder`
        /// </summary>
        [JsonPropertyName("type")]
        public TrashFolderTypeField Type { get; set; }

        [JsonPropertyName("sequence_id")]
        public string? SequenceId { get; set; } = default;

        /// <summary>
        /// The name of the folder.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

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
        public string Description { get; set; }

        /// <summary>
        /// The folder size in bytes.
        /// 
        /// Be careful parsing this integer as its
        /// value can get very large.
        /// </summary>
        [JsonPropertyName("size")]
        public long Size { get; set; }

        [JsonPropertyName("path_collection")]
        public TrashFolderPathCollectionField PathCollection { get; set; }

        [JsonPropertyName("created_by")]
        public UserMini CreatedBy { get; set; }

        [JsonPropertyName("modified_by")]
        public UserMini ModifiedBy { get; set; }

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
        public UserMini OwnedBy { get; set; }

        /// <summary>
        /// The shared link for this folder. This will
        /// be `null` if a folder has been trashed, since the link will no longer
        /// be active.
        /// </summary>
        [JsonPropertyName("shared_link")]
        public string? SharedLink { get; set; } = default;

        /// <summary>
        /// The folder upload email for this folder. This will
        /// be `null` if a folder has been trashed, since the upload will no longer
        /// work.
        /// </summary>
        [JsonPropertyName("folder_upload_email")]
        public string? FolderUploadEmail { get; set; } = default;

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
        public TrashFolderItemStatusField ItemStatus { get; set; }

        public TrashFolder(string id, TrashFolderTypeField type, string name, string description, long size, TrashFolderPathCollectionField pathCollection, UserMini createdBy, UserMini modifiedBy, UserMini ownedBy, TrashFolderItemStatusField itemStatus) {
            Id = id;
            Type = type;
            Name = name;
            Description = description;
            Size = size;
            PathCollection = pathCollection;
            CreatedBy = createdBy;
            ModifiedBy = modifiedBy;
            OwnedBy = ownedBy;
            ItemStatus = itemStatus;
        }
    }
}