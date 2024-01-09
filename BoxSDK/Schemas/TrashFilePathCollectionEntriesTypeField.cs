using System.ComponentModel;
using Serializer;
using System.Text.Json.Serialization;

namespace Box.Schemas {
    [JsonConverter(typeof(StringEnumConverter<TrashFilePathCollectionEntriesTypeField>))]
    public enum TrashFilePathCollectionEntriesTypeField {
        [Description("folder")]
        Folder
    }
}