using System.IO;
using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text.Json.Serialization;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class CreateCommentRequestBodyArg {
        /// <summary>
        /// The text of the comment.
        /// 
        /// To mention a user, use the `tagged_message`
        /// parameter instead.
        /// </summary>
        [JsonPropertyName("message")]
        public string Message { get; set; }

        /// <summary>
        /// The text of the comment, including `@[user_id:name]`
        /// somewhere in the message to mention another user, which
        /// will send them an email notification, letting them know
        /// they have been mentioned.
        /// 
        /// The `user_id` is the target user's ID, where the `name`
        /// can be any custom phrase. In the Box UI this name will
        /// link to the user's profile.
        /// 
        /// If you are not mentioning another user, use `message`
        /// instead.
        /// </summary>
        [JsonPropertyName("tagged_message")]
        public string? TaggedMessage { get; set; } = default;

        /// <summary>
        /// The item to attach the comment to.
        /// </summary>
        [JsonPropertyName("item")]
        public CreateCommentRequestBodyArgItemField Item { get; set; }

        public CreateCommentRequestBodyArg(string message, CreateCommentRequestBodyArgItemField item) {
            Message = message;
            Item = item;
        }
    }
}