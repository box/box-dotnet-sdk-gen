using System.ComponentModel;
using Serializer;
using System.Text.Json.Serialization;

namespace Box.Sdk.Gen.Schemas {
    [JsonConverter(typeof(StringEnumConverter<TrashFolderRestoredTypeField>))]
    public enum TrashFolderRestoredTypeField {
        [Description("folder")]
        Folder
    }
}