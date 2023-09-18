using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;

namespace Box.Schemas {
    public class TrashWebLink {
        /// <summary>
        /// `web_link`
        /// </summary>
        [JsonPropertyName("type")]
        public TrashWebLinkTypeField? Type { get; set; } = default;

        /// <summary>
        /// The unique identifier for this web link
        /// </summary>
        [JsonPropertyName("id")]
        public string? Id { get; set; } = default;

        [JsonPropertyName("sequence_id")]
        public string? SequenceId { get; set; } = default;

        /// <summary>
        /// The entity tag of this web link. Used with `If-Match`
        /// headers.
        /// </summary>
        [JsonPropertyName("etag")]
        public string? Etag { get; set; } = default;

        /// <summary>
        /// The name of the web link
        /// </summary>
        [JsonPropertyName("name")]
        public string? Name { get; set; } = default;

        /// <summary>
        /// The URL this web link points to
        /// </summary>
        [JsonPropertyName("url")]
        public string? Url { get; set; } = default;

        [JsonPropertyName("parent")]
        public FolderMini? Parent { get; set; } = default;

        /// <summary>
        /// The description accompanying the web link. This is
        /// visible within the Box web application.
        /// </summary>
        [JsonPropertyName("description")]
        public string? Description { get; set; } = default;

        [JsonPropertyName("path_collection")]
        public TrashWebLinkPathCollectionField? PathCollection { get; set; } = default;

        /// <summary>
        /// When this file was created on Box’s servers.
        /// </summary>
        [JsonPropertyName("created_at")]
        public string? CreatedAt { get; set; } = default;

        /// <summary>
        /// When this file was last updated on the Box
        /// servers.
        /// </summary>
        [JsonPropertyName("modified_at")]
        public string? ModifiedAt { get; set; } = default;

        /// <summary>
        /// When this file was last moved to the trash.
        /// </summary>
        [JsonPropertyName("trashed_at")]
        public string? TrashedAt { get; set; } = default;

        /// <summary>
        /// When this file will be permanently deleted.
        /// </summary>
        [JsonPropertyName("purged_at")]
        public string? PurgedAt { get; set; } = default;

        [JsonPropertyName("created_by")]
        public UserMini? CreatedBy { get; set; } = default;

        [JsonPropertyName("modified_by")]
        public UserMini? ModifiedBy { get; set; } = default;

        [JsonPropertyName("owned_by")]
        public UserMini? OwnedBy { get; set; } = default;

        /// <summary>
        /// The shared link for this bookmark. This will
        /// be `null` if a bookmark has been trashed, since the link will no longer
        /// be active.
        /// </summary>
        [JsonPropertyName("shared_link")]
        public string? SharedLink { get; set; } = default;

        /// <summary>
        /// Whether this item is deleted or not. Values include `active`,
        /// `trashed` if the file has been moved to the trash, and `deleted` if
        /// the file has been permanently deleted
        /// </summary>
        [JsonPropertyName("item_status")]
        public TrashWebLinkItemStatusField? ItemStatus { get; set; } = default;

        public TrashWebLink() {
            
        }
    }
}