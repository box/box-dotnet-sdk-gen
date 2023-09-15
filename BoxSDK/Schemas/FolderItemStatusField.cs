using System.ComponentModel;
using Serializer;
using System.Text.Json.Serialization;

namespace Box.Schemas {
    [JsonConverter(typeof(StringEnumConverter<FolderItemStatusField>))]
    public enum FolderItemStatusField {
        [Description("active")]
        Active,
        [Description("trashed")]
        Trashed,
        [Description("deleted")]
        Deleted
    }
}