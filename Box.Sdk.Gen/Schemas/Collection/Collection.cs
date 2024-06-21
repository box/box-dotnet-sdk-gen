using Unions;
using Box.Sdk.Gen;
using System.Text.Json.Serialization;
using Serializer;

namespace Box.Sdk.Gen.Schemas {
    public class Collection {
        /// <summary>
        /// The unique identifier for this collection.
        /// </summary>
        [JsonPropertyName("id")]
        public string? Id { get; init; }

        /// <summary>
        /// `collection`
        /// </summary>
        [JsonPropertyName("type")]
        [JsonConverter(typeof(StringEnumConverter<CollectionTypeField>))]
        public StringEnum<CollectionTypeField>? Type { get; init; }

        /// <summary>
        /// The name of the collection.
        /// </summary>
        [JsonPropertyName("name")]
        [JsonConverter(typeof(StringEnumConverter<CollectionNameField>))]
        public StringEnum<CollectionNameField>? Name { get; init; }

        /// <summary>
        /// The type of the collection. This is used to
        /// determine the proper visual treatment for
        /// collections.
        /// </summary>
        [JsonPropertyName("collection_type")]
        [JsonConverter(typeof(StringEnumConverter<CollectionCollectionTypeField>))]
        public StringEnum<CollectionCollectionTypeField>? CollectionType { get; init; }

        public Collection() {
            
        }
    }
}