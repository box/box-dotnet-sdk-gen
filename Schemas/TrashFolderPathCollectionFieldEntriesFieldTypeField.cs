using System.ComponentModel;
using Serializer;
using System.Text.Json.Serialization;

namespace Box.Schemas {
    [JsonConverter(typeof(StringEnumConverter<TrashFolderPathCollectionFieldEntriesFieldTypeField>))]
    public enum TrashFolderPathCollectionFieldEntriesFieldTypeField {
        [Description("folder")]
        Folder
    }
}