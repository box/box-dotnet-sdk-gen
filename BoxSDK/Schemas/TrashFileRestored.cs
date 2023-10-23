using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Text.Json;

namespace Box.Schemas {
    public class TrashFileRestored {
        /// <summary>
        /// The unique identifier that represent a file.
        /// 
        /// The ID for any file can be determined
        /// by visiting a file in the web application
        /// and copying the ID from the URL. For example,
        /// for the URL `https://*.app.box.com/files/123`
        /// the `file_id` is `123`.
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; }

        /// <summary>
        /// The HTTP `etag` of this file. This can be used within some API
        /// endpoints in the `If-Match` and `If-None-Match` headers to only
        /// perform changes on the file if (no) changes have happened.
        /// </summary>
        [JsonPropertyName("etag")]
        public string? Etag { get; set; } = default;

        /// <summary>
        /// `file`
        /// </summary>
        [JsonPropertyName("type")]
        public TrashFileRestoredTypeField Type { get; set; }

        [JsonPropertyName("sequence_id")]
        public string SequenceId { get; set; }

        /// <summary>
        /// The name of the file
        /// </summary>
        [JsonPropertyName("name")]
        public string? Name { get; set; } = default;

        /// <summary>
        /// The SHA1 hash of the file. This can be used to compare the contents
        /// of a file on Box with a local file.
        /// </summary>
        [JsonPropertyName("sha1")]
        public string Sha1 { get; set; }

        [JsonPropertyName("file_version")]
        public FileVersionMini? FileVersion { get; set; } = default;

        /// <summary>
        /// The optional description of this file
        /// </summary>
        [JsonPropertyName("description")]
        public string Description { get; set; }

        /// <summary>
        /// The file size in bytes. Be careful parsing this integer as it can
        /// get very large and cause an integer overflow.
        /// </summary>
        [JsonPropertyName("size")]
        public long Size { get; set; }

        [JsonPropertyName("path_collection")]
        public TrashFileRestoredPathCollectionField PathCollection { get; set; }

        /// <summary>
        /// The date and time when the file was created on Box.
        /// </summary>
        [JsonPropertyName("created_at")]
        public string CreatedAt { get; set; }

        /// <summary>
        /// The date and time when the file was last updated on Box.
        /// </summary>
        [JsonPropertyName("modified_at")]
        public string ModifiedAt { get; set; }

        /// <summary>
        /// The time at which this file was put in the
        /// trash - becomes `null` after restore.
        /// </summary>
        [JsonPropertyName("trashed_at")]
        public string? TrashedAt { get; set; } = default;

        /// <summary>
        /// The time at which this file is expected to be purged
        /// from the trash  - becomes `null` after restore.
        /// </summary>
        [JsonPropertyName("purged_at")]
        public string? PurgedAt { get; set; } = default;

        /// <summary>
        /// The date and time at which this file was originally
        /// created, which might be before it was uploaded to Box.
        /// </summary>
        [JsonPropertyName("content_created_at")]
        public string? ContentCreatedAt { get; set; } = default;

        /// <summary>
        /// The date and time at which this file was last updated,
        /// which might be before it was uploaded to Box.
        /// </summary>
        [JsonPropertyName("content_modified_at")]
        public string? ContentModifiedAt { get; set; } = default;

        [JsonPropertyName("created_by")]
        public UserMini? CreatedBy { get; set; } = default;

        [JsonPropertyName("modified_by")]
        public UserMini ModifiedBy { get; set; }

        [JsonPropertyName("owned_by")]
        public UserMini OwnedBy { get; set; }

        /// <summary>
        /// The shared link for this file. This will
        /// be `null` if a file had been trashed, even though the original shared
        /// link does become active again.
        /// </summary>
        [JsonPropertyName("shared_link")]
        public string? SharedLink { get; set; } = default;

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
        public TrashFileRestoredItemStatusField ItemStatus { get; set; }

        public TrashFileRestored(string id, TrashFileRestoredTypeField type, string sequenceId, string sha1, string description, long size, TrashFileRestoredPathCollectionField pathCollection, string createdAt, string modifiedAt, UserMini modifiedBy, UserMini ownedBy, TrashFileRestoredItemStatusField itemStatus) {
            Id = id;
            Type = type;
            SequenceId = sequenceId;
            Sha1 = sha1;
            Description = description;
            Size = size;
            PathCollection = pathCollection;
            CreatedAt = createdAt;
            ModifiedAt = modifiedAt;
            ModifiedBy = modifiedBy;
            OwnedBy = ownedBy;
            ItemStatus = itemStatus;
        }
    }
}