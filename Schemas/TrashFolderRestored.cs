using System.IO;
using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;

namespace Box.Schemas {
    public class TrashFolderRestored {
        [JsonPropertyName("id")]
        public string Id { get; }

        [JsonPropertyName("etag")]
        public string Etag { get; }

        [JsonPropertyName("type")]
        public TrashFolderRestoredTypeField Type { get; }

        [JsonPropertyName("sequence_id")]
        public string SequenceId { get; }

        [JsonPropertyName("name")]
        public string Name { get; }

        [JsonPropertyName("created_at")]
        public string CreatedAt { get; }

        [JsonPropertyName("modified_at")]
        public string ModifiedAt { get; }

        [JsonPropertyName("description")]
        public string Description { get; }

        [JsonPropertyName("size")]
        public int? Size { get; }

        [JsonPropertyName("path_collection")]
        public TrashFolderRestoredPathCollectionField PathCollection { get; }

        [JsonPropertyName("created_by")]
        public UserMini CreatedBy { get; }

        [JsonPropertyName("modified_by")]
        public UserMini ModifiedBy { get; }

        [JsonPropertyName("trashed_at")]
        public string TrashedAt { get; }

        [JsonPropertyName("purged_at")]
        public string PurgedAt { get; }

        [JsonPropertyName("content_created_at")]
        public string ContentCreatedAt { get; }

        [JsonPropertyName("content_modified_at")]
        public string ContentModifiedAt { get; }

        [JsonPropertyName("owned_by")]
        public UserMini OwnedBy { get; }

        [JsonPropertyName("shared_link")]
        public string SharedLink { get; }

        [JsonPropertyName("folder_upload_email")]
        public string FolderUploadEmail { get; }

        [JsonPropertyName("parent")]
        public FolderMini Parent { get; }

        [JsonPropertyName("item_status")]
        public TrashFolderRestoredItemStatusField ItemStatus { get; }

        public TrashFolderRestored(string id, string etag, TrashFolderRestoredTypeField type, string sequenceId, string name, string createdAt, string modifiedAt, string description, int? size, TrashFolderRestoredPathCollectionField pathCollection, UserMini createdBy, UserMini modifiedBy, string trashedAt, string purgedAt, string contentCreatedAt, string contentModifiedAt, UserMini ownedBy, string sharedLink, string folderUploadEmail, FolderMini parent, TrashFolderRestoredItemStatusField itemStatus) {
            Id = id;
            Etag = etag;
            Type = type;
            SequenceId = sequenceId;
            Name = name;
            CreatedAt = createdAt;
            ModifiedAt = modifiedAt;
            Description = description;
            Size = size;
            PathCollection = pathCollection;
            CreatedBy = createdBy;
            ModifiedBy = modifiedBy;
            TrashedAt = trashedAt;
            PurgedAt = purgedAt;
            ContentCreatedAt = contentCreatedAt;
            ContentModifiedAt = contentModifiedAt;
            OwnedBy = ownedBy;
            SharedLink = sharedLink;
            FolderUploadEmail = folderUploadEmail;
            Parent = parent;
            ItemStatus = itemStatus;
        }
    }
}