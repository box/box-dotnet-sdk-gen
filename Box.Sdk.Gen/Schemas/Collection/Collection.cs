using Unions;
using System.Text.Json.Serialization;

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
        public CollectionTypeField? Type { get; init; }

        /// <summary>
        /// The name of the collection.
        /// </summary>
        [JsonPropertyName("name")]
        public CollectionNameField? Name { get; init; }

        /// <summary>
        /// The type of the collection. This is used to
        /// determine the proper visual treatment for
        /// collections.
        /// </summary>
        [JsonPropertyName("collection_type")]
        public CollectionCollectionTypeField? CollectionType { get; init; }

        public Collection() {
            
        }
    }
}