using System.ComponentModel;
using Serializer;
using System.Text.Json.Serialization;

namespace Box.Schemas {
    [JsonConverter(typeof(StringEnumConverter<TrashFilePathCollectionFieldEntriesFieldTypeField>))]
    public enum TrashFilePathCollectionFieldEntriesFieldTypeField {
        [Description("folder")]
        Folder
    }
}