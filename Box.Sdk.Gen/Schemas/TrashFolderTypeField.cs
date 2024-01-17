using System.ComponentModel;
using Serializer;
using System.Text.Json.Serialization;

namespace Box.Sdk.Gen.Schemas {
    [JsonConverter(typeof(StringEnumConverter<TrashFolderTypeField>))]
    public enum TrashFolderTypeField {
        [Description("folder")]
        Folder
    }
}