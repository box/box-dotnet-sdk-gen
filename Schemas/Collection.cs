using System.IO;
using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;

namespace Box.Schemas {
    public class Collection {
        [JsonPropertyName("id")]
        public string Id { get; }

        [JsonPropertyName("type")]
        public CollectionTypeField Type { get; }

        [JsonPropertyName("name")]
        public CollectionNameField Name { get; }

        [JsonPropertyName("collection_type")]
        public CollectionCollectionTypeField CollectionType { get; }

        public Collection(string id, CollectionTypeField type, CollectionNameField name, CollectionCollectionTypeField collectionType) {
            Id = id;
            Type = type;
            Name = name;
            CollectionType = collectionType;
        }
    }
}