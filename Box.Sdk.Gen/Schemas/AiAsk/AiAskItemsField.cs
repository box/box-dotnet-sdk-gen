using Unions;
using System.Text.Json.Serialization;

namespace Box.Sdk.Gen.Schemas {
    public class AiAskItemsField {
        /// <summary>
        /// The id of the item
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; }

        /// <summary>
        /// The type of the item
        /// </summary>
        [JsonPropertyName("type")]
        public AiAskItemsTypeField Type { get; set; }

        /// <summary>
        /// The content of the item, often the text representation.
        /// </summary>
        [JsonPropertyName("content")]
        public string? Content { get; set; } = default;

        public AiAskItemsField(string id, AiAskItemsTypeField type = AiAskItemsTypeField.File) {
            Id = id;
            Type = type;
        }
    }
}