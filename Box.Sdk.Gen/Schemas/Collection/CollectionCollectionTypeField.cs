using System.ComponentModel;
using Serializer;
using System.Text.Json.Serialization;

namespace Box.Sdk.Gen.Schemas {
    [JsonConverter(typeof(StringEnumConverter<CollectionCollectionTypeField>))]
    public enum CollectionCollectionTypeField {
        [Description("favorites")]
        Favorites
    }
}