using System.ComponentModel;
using Serializer;
using System.Text.Json.Serialization;

namespace Box.Schemas {
    [JsonConverter(typeof(StringEnumConverter<MetadataQueryIndexFieldsFieldSortDirectionField>))]
    public enum MetadataQueryIndexFieldsFieldSortDirectionField {
        [Description("asc")]
        Asc,
        [Description("desc")]
        Desc
    }
}