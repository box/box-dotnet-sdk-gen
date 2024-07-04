using Box.Sdk.Gen;
using System.Text.Json.Serialization;
using Box.Sdk.Gen.Internal;

namespace Box.Sdk.Gen.Schemas {
    public class AiAskItemsField {
        /// <summary>
        /// The id of the item.
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; }

        /// <summary>
        /// The type of the item.
        /// </summary>
        [JsonPropertyName("type")]
        [JsonConverter(typeof(StringEnumConverter<AiAskItemsTypeField>))]
        public StringEnum<AiAskItemsTypeField> Type { get; }

        /// <summary>
        /// The content of the item, often the text representation.
        /// </summary>
        [JsonPropertyName("content")]
        public string? Content { get; init; }

        public AiAskItemsField(string id, AiAskItemsTypeField type = AiAskItemsTypeField.File) {
            Id = id;
            Type = type;
        }
        
        [JsonConstructorAttribute]
        internal AiAskItemsField(string id, StringEnum<AiAskItemsTypeField> type) {
            Id = id;
            Type = AiAskItemsTypeField.File;
        }
    }
}