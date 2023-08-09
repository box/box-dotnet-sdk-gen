using System.IO;
using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text.Json.Serialization;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class CreateCommentRequestBodyArg {
        [JsonPropertyName("message")]
        public string Message { get; }

        [JsonPropertyName("tagged_message")]
        public string TaggedMessage { get; }

        [JsonPropertyName("item")]
        public CreateCommentRequestBodyArgItemField Item { get; }

        public CreateCommentRequestBodyArg(string message, string taggedMessage, CreateCommentRequestBodyArgItemField item) {
            Message = message;
            TaggedMessage = taggedMessage;
            Item = item;
        }
    }
}