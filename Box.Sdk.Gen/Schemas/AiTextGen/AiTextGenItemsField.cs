using Box.Sdk.Gen;
using System.Text.Json.Serialization;
using Box.Sdk.Gen.Internal;
using Box.Sdk.Gen.Schemas;

namespace Box.Sdk.Gen.Schemas {
    public class AiTextGenItemsField {
        /// <summary>
        /// The ID of the item.
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; }

        /// <summary>
        /// The type of the item.
        /// </summary>
        [JsonPropertyName("type")]
        [JsonConverter(typeof(StringEnumConverter<AiTextGenItemsTypeField>))]
        public StringEnum<AiTextGenItemsTypeField> Type { get; }

        /// <summary>
        /// The content to use as context for generating new text or editing existing text.
        /// </summary>
        [JsonPropertyName("content")]
        public string? Content { get; init; }

        public AiTextGenItemsField(string id, AiTextGenItemsTypeField type = AiTextGenItemsTypeField.File) {
            Id = id;
            Type = type;
        }
        
        [JsonConstructorAttribute]
        internal AiTextGenItemsField(string id, StringEnum<AiTextGenItemsTypeField> type) {
            Id = id;
            Type = AiTextGenItemsTypeField.File;
        }
    }
}