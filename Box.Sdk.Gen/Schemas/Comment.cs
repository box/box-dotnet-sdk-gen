using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Text.Json;

namespace Box.Sdk.Gen.Schemas {
    public class Comment : CommentBase {
        /// <summary>
        /// Whether or not this comment is a reply to another
        /// comment
        /// </summary>
        [JsonPropertyName("is_reply_comment")]
        public bool? IsReplyComment { get; set; } = default;

        /// <summary>
        /// The text of the comment, as provided by the user
        /// </summary>
        [JsonPropertyName("message")]
        public string? Message { get; set; } = default;

        [JsonPropertyName("created_by")]
        public UserMini? CreatedBy { get; set; } = default;

        /// <summary>
        /// The time this comment was created
        /// </summary>
        [JsonPropertyName("created_at")]
        public System.DateTimeOffset? CreatedAt { get; set; } = default;

        /// <summary>
        /// The time this comment was last modified
        /// </summary>
        [JsonPropertyName("modified_at")]
        public System.DateTimeOffset? ModifiedAt { get; set; } = default;

        [JsonPropertyName("item")]
        public CommentItemField? Item { get; set; } = default;

        public Comment() {
            
        }
    }
}