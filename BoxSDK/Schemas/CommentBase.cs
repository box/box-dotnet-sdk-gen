using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;

namespace Box.Schemas {
    public class CommentBase {
        /// <summary>
        /// The unique identifier for this comment.
        /// </summary>
        [JsonPropertyName("id")]
        public string? Id { get; set; } = default;

        /// <summary>
        /// `comment`
        /// </summary>
        [JsonPropertyName("type")]
        public CommentBaseTypeField? Type { get; set; } = default;

        public CommentBase() {
            
        }
    }
}