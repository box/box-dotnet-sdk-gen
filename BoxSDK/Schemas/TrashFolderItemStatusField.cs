using System.ComponentModel;
using Serializer;
using System.Text.Json.Serialization;

namespace Box.Schemas {
    [JsonConverter(typeof(StringEnumConverter<TrashFolderItemStatusField>))]
    public enum TrashFolderItemStatusField {
        [Description("active")]
        Active,
        [Description("trashed")]
        Trashed,
        [Description("deleted")]
        Deleted
    }
}