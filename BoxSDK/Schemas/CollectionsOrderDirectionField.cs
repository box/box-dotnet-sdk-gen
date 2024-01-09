using System.ComponentModel;
using Serializer;
using System.Text.Json.Serialization;

namespace Box.Schemas {
    [JsonConverter(typeof(StringEnumConverter<CollectionsOrderDirectionField>))]
    public enum CollectionsOrderDirectionField {
        [Description("ASC")]
        Asc,
        [Description("DESC")]
        Desc
    }
}