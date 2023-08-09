using System.IO;
using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;

namespace Box.Schemas {
    public class File : FileMini {
        [JsonPropertyName("description")]
        public string Description { get; }

        [JsonPropertyName("size")]
        public int? Size { get; }

        [JsonPropertyName("path_collection")]
        public FilePathCollectionField PathCollection { get; }

        [JsonPropertyName("created_at")]
        public string CreatedAt { get; }

        [JsonPropertyName("modified_at")]
        public string ModifiedAt { get; }

        [JsonPropertyName("trashed_at")]
        public string TrashedAt { get; }

        [JsonPropertyName("purged_at")]
        public string PurgedAt { get; }

        [JsonPropertyName("content_created_at")]
        public string ContentCreatedAt { get; }

        [JsonPropertyName("content_modified_at")]
        public string ContentModifiedAt { get; }

        [JsonPropertyName("created_by")]
        public UserMini CreatedBy { get; }

        [JsonPropertyName("modified_by")]
        public UserMini ModifiedBy { get; }

        [JsonPropertyName("owned_by")]
        public UserMini OwnedBy { get; }

        [JsonPropertyName("shared_link")]
        public FileSharedLinkField SharedLink { get; }

        [JsonPropertyName("parent")]
        public FolderMini Parent { get; }

        [JsonPropertyName("item_status")]
        public FileItemStatusField ItemStatus { get; }

        public File(string id, string etag, FileBaseTypeField type, string sequenceId, string name, string sha1, FileVersionMini fileVersion, string description, int? size, FilePathCollectionField pathCollection, string createdAt, string modifiedAt, string trashedAt, string purgedAt, string contentCreatedAt, string contentModifiedAt, UserMini createdBy, UserMini modifiedBy, UserMini ownedBy, FileSharedLinkField sharedLink, FolderMini parent, FileItemStatusField itemStatus) : base(id, etag, type, sequenceId, name, sha1, fileVersion) {
            Description = description;
            Size = size;
            PathCollection = pathCollection;
            CreatedAt = createdAt;
            ModifiedAt = modifiedAt;
            TrashedAt = trashedAt;
            PurgedAt = purgedAt;
            ContentCreatedAt = contentCreatedAt;
            ContentModifiedAt = contentModifiedAt;
            CreatedBy = createdBy;
            ModifiedBy = modifiedBy;
            OwnedBy = ownedBy;
            SharedLink = sharedLink;
            Parent = parent;
            ItemStatus = itemStatus;
        }
    }
}