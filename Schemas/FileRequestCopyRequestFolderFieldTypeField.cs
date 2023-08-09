using System.ComponentModel;
using Serializer;
using System.Text.Json.Serialization;

namespace Box.Schemas {
    [JsonConverter(typeof(StringEnumConverter<FileRequestCopyRequestFolderFieldTypeField>))]
    public enum FileRequestCopyRequestFolderFieldTypeField {
        [Description("folder")]
        Folder
    }
}