using System.ComponentModel;
using Serializer;
using System.Text.Json.Serialization;

namespace Box.Sdk.Gen.Schemas {
    [JsonConverter(typeof(StringEnumConverter<CollectionTypeField>))]
    public enum CollectionTypeField {
        [Description("collection")]
        Collection
    }
}