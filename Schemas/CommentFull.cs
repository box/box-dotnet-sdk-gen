using System.IO;
using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;

namespace Box.Schemas {
    public class CommentFull : Comment {
        [JsonPropertyName("tagged_message")]
        public string TaggedMessage { get; }

        public CommentFull(string id, CommentBaseTypeField type, bool? isReplyComment, string message, UserMini createdBy, string createdAt, string modifiedAt, CommentItemField item, string taggedMessage) : base(id, type, isReplyComment, message, createdBy, createdAt, modifiedAt, item) {
            TaggedMessage = taggedMessage;
        }
    }
}