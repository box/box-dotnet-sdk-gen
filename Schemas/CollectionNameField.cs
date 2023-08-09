using System.ComponentModel;
using Serializer;
using System.Text.Json.Serialization;

namespace Box.Schemas {
    [JsonConverter(typeof(StringEnumConverter<CollectionNameField>))]
    public enum CollectionNameField {
        [Description("Favorites")]
        Favorites
    }
}