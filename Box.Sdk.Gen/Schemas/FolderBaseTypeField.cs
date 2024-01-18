using System.ComponentModel;
using Serializer;
using System.Text.Json.Serialization;

namespace Box.Sdk.Gen.Schemas {
    [JsonConverter(typeof(StringEnumConverter<FolderBaseTypeField>))]
    public enum FolderBaseTypeField {
        [Description("folder")]
        Folder
    }
}