using Box.Sdk.Gen;
using System.Text.Json.Serialization;
using Box.Sdk.Gen.Internal;

namespace Box.Sdk.Gen.Schemas {
    public class AiItemBase {
        /// <summary>
        /// The ID of the file.
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; }

        /// <summary>
        /// The type of the item. Currently the value can be `file` only.
        /// </summary>
        [JsonPropertyName("type")]
        [JsonConverter(typeof(StringEnumConverter<AiItemBaseTypeField>))]
        public StringEnum<AiItemBaseTypeField> Type { get; }

        /// <summary>
        /// The content of the item, often the text representation.
        /// </summary>
        [JsonPropertyName("content")]
        public string? Content { get; init; }

        public AiItemBase(string id, AiItemBaseTypeField type = AiItemBaseTypeField.File) {
            Id = id;
            Type = type;
        }
        
        [JsonConstructorAttribute]
        internal AiItemBase(string id, StringEnum<AiItemBaseTypeField> type) {
            Id = id;
            Type = AiItemBaseTypeField.File;
        }
    }
}