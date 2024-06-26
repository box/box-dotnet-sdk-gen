using Unions;
using Box.Sdk.Gen;
using System.Text.Json.Serialization;
using Serializer;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using Box.Sdk.Gen.Schemas;

namespace Box.Sdk.Gen.Schemas {
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
        public string Id { get; }

        /// <summary>
        /// The HTTP `etag` of this folder. This can be used within some API
        /// endpoints in the `If-Match` and `If-None-Match` headers to only
        /// perform changes on the folder if (no) changes have happened.
        /// </summary>
        [JsonPropertyName("etag")]
        public string? Etag { get; init; }

        /// <summary>
        /// `folder`
        /// </summary>
        [JsonPropertyName("type")]
        [JsonConverter(typeof(StringEnumConverter<TrashFolderTypeField>))]
        public StringEnum<TrashFolderTypeField> Type { get; }

        [JsonPropertyName("sequence_id")]
        public string? SequenceId { get; init; }

        /// <summary>
        /// The name of the folder.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; }

        /// <summary>
        /// The date and time when the folder was created. This value may
        /// be `null` for some folders such as the root folder or the trash
        /// folder.
        /// </summary>
        [JsonPropertyName("created_at")]
        public System.DateTimeOffset? CreatedAt { get; init; }

        /// <summary>
        /// The date and time when the folder was last updated. This value may
        /// be `null` for some folders such as the root folder or the trash
        /// folder.
        /// </summary>
        [JsonPropertyName("modified_at")]
        public System.DateTimeOffset? ModifiedAt { get; init; }

        [JsonPropertyName("description")]
        public string Description { get; }

        /// <summary>
        /// The folder size in bytes.
        /// 
        /// Be careful parsing this integer as its
        /// value can get very large.
        /// </summary>
        [JsonPropertyName("size")]
        public long Size { get; }

        [JsonPropertyName("path_collection")]
        public TrashFolderPathCollectionField PathCollection { get; }

        [JsonPropertyName("created_by")]
        public UserMini CreatedBy { get; }

        [JsonPropertyName("modified_by")]
        public UserMini ModifiedBy { get; }

        /// <summary>
        /// The time at which this folder was put in the trash.
        /// </summary>
        [JsonPropertyName("trashed_at")]
        public System.DateTimeOffset? TrashedAt { get; init; }

        /// <summary>
        /// The time at which this folder is expected to be purged
        /// from the trash.
        /// </summary>
        [JsonPropertyName("purged_at")]
        public System.DateTimeOffset? PurgedAt { get; init; }

        /// <summary>
        /// The date and time at which this folder was originally
        /// created.
        /// </summary>
        [JsonPropertyName("content_created_at")]
        public System.DateTimeOffset? ContentCreatedAt { get; init; }

        /// <summary>
        /// The date and time at which this folder was last updated.
        /// </summary>
        [JsonPropertyName("content_modified_at")]
        public System.DateTimeOffset? ContentModifiedAt { get; init; }

        [JsonPropertyName("owned_by")]
        public UserMini OwnedBy { get; }

        /// <summary>
        /// The shared link for this folder. This will
        /// be `null` if a folder has been trashed, since the link will no longer
        /// be active.
        /// </summary>
        [JsonPropertyName("shared_link")]
        public string? SharedLink { get; init; }

        /// <summary>
        /// The folder upload email for this folder. This will
        /// be `null` if a folder has been trashed, since the upload will no longer
        /// work.
        /// </summary>
        [JsonPropertyName("folder_upload_email")]
        public string? FolderUploadEmail { get; init; }

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
        [JsonConverter(typeof(StringEnumConverter<TrashFolderItemStatusField>))]
        public StringEnum<TrashFolderItemStatusField> ItemStatus { get; }

        public TrashFolder(string id, string name, string description, long size, TrashFolderPathCollectionField pathCollection, UserMini createdBy, UserMini modifiedBy, UserMini ownedBy, TrashFolderItemStatusField itemStatus, TrashFolderTypeField type = TrashFolderTypeField.Folder) {
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
        
        [JsonConstructorAttribute]
        internal TrashFolder(string id, string name, string description, long size, TrashFolderPathCollectionField pathCollection, UserMini createdBy, UserMini modifiedBy, UserMini ownedBy, StringEnum<TrashFolderItemStatusField> itemStatus, StringEnum<TrashFolderTypeField> type) {
            Id = id;
            Type = TrashFolderTypeField.Folder;
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