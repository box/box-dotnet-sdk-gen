using System.ComponentModel;
using Serializer;
using System.Text.Json.Serialization;

namespace Box.Schemas {
    [JsonConverter(typeof(StringEnumConverter<MetadataQueryIndexFieldsSortDirectionField>))]
    public enum MetadataQueryIndexFieldsSortDirectionField {
        [Description("asc")]
        Asc,
        [Description("desc")]
        Desc
    }
}