using Box.Sdk.Gen;
using System.Text.Json.Serialization;
using Box.Sdk.Gen.Schemas;

namespace Box.Sdk.Gen.Schemas {
    public class Comment : CommentBase {
        /// <summary>
        /// Whether or not this comment is a reply to another
        /// comment
        /// </summary>
        [JsonPropertyName("is_reply_comment")]
        public bool? IsReplyComment { get; init; }

        /// <summary>
        /// The text of the comment, as provided by the user
        /// </summary>
        [JsonPropertyName("message")]
        public string? Message { get; init; }

        [JsonPropertyName("created_by")]
        public UserMini? CreatedBy { get; init; }

        /// <summary>
        /// The time this comment was created
        /// </summary>
        [JsonPropertyName("created_at")]
        public System.DateTimeOffset? CreatedAt { get; init; }

        /// <summary>
        /// The time this comment was last modified
        /// </summary>
        [JsonPropertyName("modified_at")]
        public System.DateTimeOffset? ModifiedAt { get; init; }

        [JsonPropertyName("item")]
        public CommentItemField? Item { get; init; }

        public Comment() {
            
        }
    }
}