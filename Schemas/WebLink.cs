using System.IO;
using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;

namespace Box.Schemas {
    public class WebLink : WebLinkMini {
        [JsonPropertyName("parent")]
        public FolderMini Parent { get; }

        [JsonPropertyName("description")]
        public string Description { get; }

        [JsonPropertyName("path_collection")]
        public WebLinkPathCollectionField PathCollection { get; }

        [JsonPropertyName("created_at")]
        public string CreatedAt { get; }

        [JsonPropertyName("modified_at")]
        public string ModifiedAt { get; }

        [JsonPropertyName("trashed_at")]
        public string TrashedAt { get; }

        [JsonPropertyName("purged_at")]
        public string PurgedAt { get; }

        [JsonPropertyName("created_by")]
        public UserMini CreatedBy { get; }

        [JsonPropertyName("modified_by")]
        public UserMini ModifiedBy { get; }

        [JsonPropertyName("owned_by")]
        public UserMini OwnedBy { get; }

        [JsonPropertyName("shared_link")]
        public WebLinkSharedLinkField SharedLink { get; }

        [JsonPropertyName("item_status")]
        public WebLinkItemStatusField ItemStatus { get; }

        public WebLink(string id, WebLinkBaseTypeField type, string etag, string url, string sequenceId, string name, FolderMini parent, string description, WebLinkPathCollectionField pathCollection, string createdAt, string modifiedAt, string trashedAt, string purgedAt, UserMini createdBy, UserMini modifiedBy, UserMini ownedBy, WebLinkSharedLinkField sharedLink, WebLinkItemStatusField itemStatus) : base(id, type, etag, url, sequenceId, name) {
            Parent = parent;
            Description = description;
            PathCollection = pathCollection;
            CreatedAt = createdAt;
            ModifiedAt = modifiedAt;
            TrashedAt = trashedAt;
            PurgedAt = purgedAt;
            CreatedBy = createdBy;
            ModifiedBy = modifiedBy;
            OwnedBy = ownedBy;
            SharedLink = sharedLink;
            ItemStatus = itemStatus;
        }
    }
}