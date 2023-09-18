using System.ComponentModel;
using Serializer;
using System.Text.Json.Serialization;

namespace Box.Schemas {
    [JsonConverter(typeof(StringEnumConverter<FileItemStatusField>))]
    public enum FileItemStatusField {
        [Description("active")]
        Active,
        [Description("trashed")]
        Trashed,
        [Description("deleted")]
        Deleted
    }
}