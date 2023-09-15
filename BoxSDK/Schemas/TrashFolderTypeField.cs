using System.ComponentModel;
using Serializer;
using System.Text.Json.Serialization;

namespace Box.Schemas {
    [JsonConverter(typeof(StringEnumConverter<TrashFolderTypeField>))]
    public enum TrashFolderTypeField {
        [Description("folder")]
        Folder
    }
}