using System.ComponentModel;
using Serializer;
using System.Text.Json.Serialization;

namespace Box.Schemas {
    [JsonConverter(typeof(StringEnumConverter<TrashFolderRestoredTypeField>))]
    public enum TrashFolderRestoredTypeField {
        [Description("folder")]
        Folder
    }
}