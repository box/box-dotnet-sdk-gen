using System.ComponentModel;
using Serializer;
using System.Text.Json.Serialization;

namespace Box.Schemas {
    [JsonConverter(typeof(StringEnumConverter<FileVersionsOrderDirectionField>))]
    public enum FileVersionsOrderDirectionField {
        [Description("ASC")]
        Asc,
        [Description("DESC")]
        Desc
    }
}