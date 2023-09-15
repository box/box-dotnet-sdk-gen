using System.ComponentModel;
using Serializer;
using System.Text.Json.Serialization;

namespace Box.Schemas {
    [JsonConverter(typeof(StringEnumConverter<CollectionsOrderFieldDirectionField>))]
    public enum CollectionsOrderFieldDirectionField {
        [Description("ASC")]
        Asc,
        [Description("DESC")]
        Desc
    }
}