using System.ComponentModel;
using Serializer;
using System.Text.Json.Serialization;

namespace Box.Schemas {
    [JsonConverter(typeof(StringEnumConverter<ZipDownloadNameConflictsFieldTypeField>))]
    public enum ZipDownloadNameConflictsFieldTypeField {
        [Description("file")]
        File,
        [Description("folder")]
        Folder
    }
}