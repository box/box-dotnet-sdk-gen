using Box.Sdk.Gen;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Box.Sdk.Gen.Internal;
using Box.Sdk.Gen.Schemas;

namespace Box.Sdk.Gen.Schemas {
    public class TrashFolderRestored {
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
        public string? Id { get; init; }

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
        [JsonConverter(typeof(StringEnumConverter<TrashFolderRestoredTypeField>))]
        public StringEnum<TrashFolderRestoredTypeField>? Type { get; init; }

        [JsonPropertyName("sequence_id")]
        public string? SequenceId { get; init; }

        /// <summary>
        /// The name of the folder.
        /// </summary>
        [JsonPropertyName("name")]
        public string? Name { get; init; }

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
        public string? Description { get; init; }

        /// <summary>
        /// The folder size in bytes.
        /// 
        /// Be careful parsing this integer as its
        /// value can get very large.
        /// </summary>
        [JsonPropertyName("size")]
        public long? Size { get; init; }

        [JsonPropertyName("path_collection")]
        public TrashFolderRestoredPathCollectionField? PathCollection { get; init; }

        [JsonPropertyName("created_by")]
        public UserMini? CreatedBy { get; init; }

        [JsonPropertyName("modified_by")]
        public UserMini? ModifiedBy { get; init; }

        /// <summary>
        /// The time at which this folder was put in the
        /// trash - becomes `null` after restore.
        /// </summary>
        [JsonPropertyName("trashed_at")]
        public string? TrashedAt { get; init; }

        /// <summary>
        /// The time at which this folder is expected to be purged
        /// from the trash  - becomes `null` after restore.
        /// </summary>
        [JsonPropertyName("purged_at")]
        public string? PurgedAt { get; init; }

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
        public UserMini? OwnedBy { get; init; }

        /// <summary>
        /// The shared link for this file. This will
        /// be `null` if a folder had been trashed, even though the original shared
        /// link does become active again.
        /// </summary>
        [JsonPropertyName("shared_link")]
        public string? SharedLink { get; init; }

        /// <summary>
        /// The folder upload email for this folder. This will
        /// be `null` if a folder has been trashed, even though the original upload
        /// email does become active again.
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
        [JsonConverter(typeof(StringEnumConverter<TrashFolderRestoredItemStatusField>))]
        public StringEnum<TrashFolderRestoredItemStatusField>? ItemStatus { get; init; }

        public TrashFolderRestored() {
            
        }
    }
}