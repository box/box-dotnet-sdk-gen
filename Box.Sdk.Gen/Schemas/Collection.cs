using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;

namespace Box.Sdk.Gen.Schemas {
    public class Collection {
        /// <summary>
        /// The unique identifier for this collection.
        /// </summary>
        [JsonPropertyName("id")]
        public string? Id { get; set; } = default;

        /// <summary>
        /// `collection`
        /// </summary>
        [JsonPropertyName("type")]
        public CollectionTypeField? Type { get; set; } = default;

        /// <summary>
        /// The name of the collection.
        /// </summary>
        [JsonPropertyName("name")]
        public CollectionNameField? Name { get; set; } = default;

        /// <summary>
        /// The type of the collection. This is used to
        /// determine the proper visual treatment for
        /// collections.
        /// </summary>
        [JsonPropertyName("collection_type")]
        public CollectionCollectionTypeField? CollectionType { get; set; } = default;

        public Collection() {
            
        }
    }
}