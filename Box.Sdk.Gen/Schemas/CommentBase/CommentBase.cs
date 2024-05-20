using Unions;
using System.Text.Json.Serialization;

namespace Box.Sdk.Gen.Schemas {
    public class CommentBase {
        /// <summary>
        /// The unique identifier for this comment.
        /// </summary>
        [JsonPropertyName("id")]
        public string? Id { get; init; }

        /// <summary>
        /// `comment`
        /// </summary>
        [JsonPropertyName("type")]
        public CommentBaseTypeField? Type { get; init; }

        public CommentBase() {
            
        }
    }
}