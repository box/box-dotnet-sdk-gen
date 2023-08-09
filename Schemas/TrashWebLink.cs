using System.IO;
using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;

namespace Box.Schemas {
    public class TrashWebLink {
        [JsonPropertyName("type")]
        public TrashWebLinkTypeField Type { get; }

        [JsonPropertyName("id")]
        public string Id { get; }

        [JsonPropertyName("sequence_id")]
        public string SequenceId { get; }

        [JsonPropertyName("etag")]
        public string Etag { get; }

        [JsonPropertyName("name")]
        public string Name { get; }

        [JsonPropertyName("url")]
        public string Url { get; }

        [JsonPropertyName("parent")]
        public FolderMini Parent { get; }

        [JsonPropertyName("description")]
        public string Description { get; }

        [JsonPropertyName("path_collection")]
        public TrashWebLinkPathCollectionField PathCollection { get; }

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
        public string SharedLink { get; }

        [JsonPropertyName("item_status")]
        public TrashWebLinkItemStatusField ItemStatus { get; }

        public TrashWebLink(TrashWebLinkTypeField type, string id, string sequenceId, string etag, string name, string url, FolderMini parent, string description, TrashWebLinkPathCollectionField pathCollection, string createdAt, string modifiedAt, string trashedAt, string purgedAt, UserMini createdBy, UserMini modifiedBy, UserMini ownedBy, string sharedLink, TrashWebLinkItemStatusField itemStatus) {
            Type = type;
            Id = id;
            SequenceId = sequenceId;
            Etag = etag;
            Name = name;
            Url = url;
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