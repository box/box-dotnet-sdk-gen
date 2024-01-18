using System.ComponentModel;
using Serializer;
using System.Text.Json.Serialization;

namespace Box.Sdk.Gen.Schemas {
    [JsonConverter(typeof(StringEnumConverter<TrashFilePathCollectionEntriesTypeField>))]
    public enum TrashFilePathCollectionEntriesTypeField {
        [Description("folder")]
        Folder
    }
}