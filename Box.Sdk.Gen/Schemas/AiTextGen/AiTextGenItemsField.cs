using Unions;
using System.Text.Json.Serialization;

namespace Box.Sdk.Gen.Schemas {
    public class AiTextGenItemsField {
        /// <summary>
        /// The id of the item.
        /// </summary>
        [JsonPropertyName("id")]
        public string? Id { get; init; }

        /// <summary>
        /// The type of the item.
        /// </summary>
        [JsonPropertyName("type")]
        public AiTextGenItemsTypeField? Type { get; init; }

        /// <summary>
        /// The content to use as context for generating new text or editing existing text.
        /// </summary>
        [JsonPropertyName("content")]
        public string? Content { get; init; }

        public AiTextGenItemsField() {
            
        }
    }
}