using System.IO;
using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Text.Json;

namespace Box.Schemas {
    public class Folder : FolderMini {
        [JsonPropertyName("created_at")]
        public string CreatedAt { get; }

        [JsonPropertyName("modified_at")]
        public string ModifiedAt { get; }

        [JsonPropertyName("description")]
        public string Description { get; }

        [JsonPropertyName("size")]
        public int? Size { get; }

        [JsonPropertyName("path_collection")]
        public FolderPathCollectionField PathCollection { get; }

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
        public FolderSharedLinkField SharedLink { get; }

        [JsonPropertyName("folder_upload_email")]
        public FolderFolderUploadEmailField FolderUploadEmail { get; }

        [JsonPropertyName("parent")]
        public FolderMini Parent { get; }

        [JsonPropertyName("item_status")]
        public FolderItemStatusField ItemStatus { get; }

        [JsonPropertyName("item_collection")]
        public Items ItemCollection { get; }

        public Folder(string id, string etag, FolderBaseTypeField type, string name, string sequenceId, string createdAt, string modifiedAt, string description, int? size, FolderPathCollectionField pathCollection, UserMini createdBy, UserMini modifiedBy, string trashedAt, string purgedAt, string contentCreatedAt, string contentModifiedAt, UserMini ownedBy, FolderSharedLinkField sharedLink, FolderFolderUploadEmailField folderUploadEmail, FolderMini parent, FolderItemStatusField itemStatus, Items itemCollection) : base(id, etag, type, name, sequenceId) {
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
            ItemCollection = itemCollection;
        }
    }
}