using Unions;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Box.Sdk.Gen.Schemas;

namespace Box.Sdk.Gen.Schemas {
    public class TrashWebLinkRestored {
        /// <summary>
        /// `web_link`
        /// </summary>
        [JsonPropertyName("type")]
        public TrashWebLinkRestoredTypeField? Type { get; init; }

        /// <summary>
        /// The unique identifier for this web link
        /// </summary>
        [JsonPropertyName("id")]
        public string? Id { get; init; }

        [JsonPropertyName("sequence_id")]
        public string SequenceId { get; }

        /// <summary>
        /// The entity tag of this web link. Used with `If-Match`
        /// headers.
        /// </summary>
        [JsonPropertyName("etag")]
        public string? Etag { get; init; }

        /// <summary>
        /// The name of the web link
        /// </summary>
        [JsonPropertyName("name")]
        public string? Name { get; init; }

        /// <summary>
        /// The URL this web link points to
        /// </summary>
        [JsonPropertyName("url")]
        public string? Url { get; init; }

        [JsonPropertyName("parent")]
        public FolderMini? Parent { get; init; }

        /// <summary>
        /// The description accompanying the web link. This is
        /// visible within the Box web application.
        /// </summary>
        [JsonPropertyName("description")]
        public string? Description { get; init; }

        [JsonPropertyName("path_collection")]
        public TrashWebLinkRestoredPathCollectionField PathCollection { get; }

        /// <summary>
        /// When this file was created on Box’s servers.
        /// </summary>
        [JsonPropertyName("created_at")]
        public System.DateTimeOffset? CreatedAt { get; init; }

        /// <summary>
        /// When this file was last updated on the Box
        /// servers.
        /// </summary>
        [JsonPropertyName("modified_at")]
        public System.DateTimeOffset? ModifiedAt { get; init; }

        /// <summary>
        /// The time at which this bookmark was put in the
        /// trash - becomes `null` after restore.
        /// </summary>
        [JsonPropertyName("trashed_at")]
        public string? TrashedAt { get; init; }

        /// <summary>
        /// The time at which this bookmark will be permanently
        /// deleted - becomes `null` after restore.
        /// </summary>
        [JsonPropertyName("purged_at")]
        public string? PurgedAt { get; init; }

        [JsonPropertyName("created_by")]
        public UserMini? CreatedBy { get; init; }

        [JsonPropertyName("modified_by")]
        public UserMini? ModifiedBy { get; init; }

        [JsonPropertyName("owned_by")]
        public UserMini? OwnedBy { get; init; }

        /// <summary>
        /// The shared link for this bookmark. This will
        /// be `null` if a bookmark had been trashed, even though the original shared
        /// link does become active again.
        /// </summary>
        [JsonPropertyName("shared_link")]
        public string? SharedLink { get; init; }

        /// <summary>
        /// Whether this item is deleted or not. Values include `active`,
        /// `trashed` if the file has been moved to the trash, and `deleted` if
        /// the file has been permanently deleted
        /// </summary>
        [JsonPropertyName("item_status")]
        public TrashWebLinkRestoredItemStatusField? ItemStatus { get; init; }

        public TrashWebLinkRestored(string sequenceId, TrashWebLinkRestoredPathCollectionField pathCollection) {
            SequenceId = sequenceId;
            PathCollection = pathCollection;
        }
    }
}