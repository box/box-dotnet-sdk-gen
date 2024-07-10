using Box.Sdk.Gen;
using System.Text.Json.Serialization;
using Box.Sdk.Gen.Internal;

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
        [JsonConverter(typeof(StringEnumConverter<CommentBaseTypeField>))]
        public StringEnum<CommentBaseTypeField>? Type { get; init; }

        public CommentBase() {
            
        }
    }
}