using System.ComponentModel;
using Serializer;
using System.Text.Json.Serialization;

namespace Box.Schemas {
    [JsonConverter(typeof(StringEnumConverter<FileRequestCopyRequestFolderTypeField>))]
    public enum FileRequestCopyRequestFolderTypeField {
        [Description("folder")]
        Folder
    }
}