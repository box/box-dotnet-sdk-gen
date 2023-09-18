using System.ComponentModel;
using Serializer;
using System.Text.Json.Serialization;

namespace Box.Schemas {
    [JsonConverter(typeof(StringEnumConverter<FileVersionsOrderFieldDirectionField>))]
    public enum FileVersionsOrderFieldDirectionField {
        [Description("ASC")]
        Asc,
        [Description("DESC")]
        Desc
    }
}