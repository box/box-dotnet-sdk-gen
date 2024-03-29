using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Text.Json;

namespace Box.Sdk.Gen.Schemas {
    public class CommentFull : Comment {
        /// <summary>
        /// The string representing the comment text with
        /// @mentions included. @mention format is @[id:username]
        /// where `id` is user's Box ID and `username` is
        /// their display name.
        /// </summary>
        [JsonPropertyName("tagged_message")]
        public string? TaggedMessage { get; set; } = default;

        public CommentFull() {
            
        }
    }
}