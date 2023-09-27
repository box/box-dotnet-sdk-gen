using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Text.Json;

namespace Box.Schemas {
    public class WebLink : WebLinkMini {
        [JsonPropertyName("parent")]
        public FolderMini? Parent { get; set; } = default;

        /// <summary>
        /// The description accompanying the web link. This is
        /// visible within the Box web application.
        /// </summary>
        [JsonPropertyName("description")]
        public string? Description { get; set; } = default;

        [JsonPropertyName("path_collection")]
        public WebLinkPathCollectionField? PathCollection { get; set; } = default;

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
        /// When this file was moved to the trash.
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

        [JsonPropertyName("shared_link")]
        public WebLinkSharedLinkField? SharedLink { get; set; } = default;

        /// <summary>
        /// Whether this item is deleted or not. Values include `active`,
        /// `trashed` if the file has been moved to the trash, and `deleted` if
        /// the file has been permanently deleted
        /// </summary>
        [JsonPropertyName("item_status")]
        public WebLinkItemStatusField? ItemStatus { get; set; } = default;

        public WebLink(string id, WebLinkBaseTypeField type) : base(id, type) {
            
        }
    }
}