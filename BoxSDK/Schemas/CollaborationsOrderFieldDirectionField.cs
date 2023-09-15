using System.ComponentModel;
using Serializer;
using System.Text.Json.Serialization;

namespace Box.Schemas {
    [JsonConverter(typeof(StringEnumConverter<CollaborationsOrderFieldDirectionField>))]
    public enum CollaborationsOrderFieldDirectionField {
        [Description("ASC")]
        Asc,
        [Description("DESC")]
        Desc
    }
}