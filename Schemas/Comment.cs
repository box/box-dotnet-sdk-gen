using System.IO;
using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;

namespace Box.Schemas {
    public class Comment : CommentBase {
        [JsonPropertyName("is_reply_comment")]
        public bool? IsReplyComment { get; }

        [JsonPropertyName("message")]
        public string Message { get; }

        [JsonPropertyName("created_by")]
        public UserMini CreatedBy { get; }

        [JsonPropertyName("created_at")]
        public string CreatedAt { get; }

        [JsonPropertyName("modified_at")]
        public string ModifiedAt { get; }

        [JsonPropertyName("item")]
        public CommentItemField Item { get; }

        public Comment(string id, CommentBaseTypeField type, bool? isReplyComment, string message, UserMini createdBy, string createdAt, string modifiedAt, CommentItemField item) : base(id, type) {
            IsReplyComment = isReplyComment;
            Message = message;
            CreatedBy = createdBy;
            CreatedAt = createdAt;
            ModifiedAt = modifiedAt;
            Item = item;
        }
    }
}