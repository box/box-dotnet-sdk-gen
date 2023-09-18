using System.ComponentModel;
using Serializer;
using System.Text.Json.Serialization;

namespace Box.Schemas {
    [JsonConverter(typeof(StringEnumConverter<CollectionCollectionTypeField>))]
    public enum CollectionCollectionTypeField {
        [Description("favorites")]
        Favorites
    }
}