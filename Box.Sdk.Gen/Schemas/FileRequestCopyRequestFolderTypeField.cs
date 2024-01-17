using System.ComponentModel;
using Serializer;
using System.Text.Json.Serialization;

namespace Box.Sdk.Gen.Schemas {
    [JsonConverter(typeof(StringEnumConverter<FileRequestCopyRequestFolderTypeField>))]
    public enum FileRequestCopyRequestFolderTypeField {
        [Description("folder")]
        Folder
    }
}