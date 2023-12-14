using System.ComponentModel;
using Serializer;
using System.Text.Json.Serialization;

namespace Box.Schemas {
    [JsonConverter(typeof(StringEnumConverter<ZipDownloadNameConflictsTypeField>))]
    public enum ZipDownloadNameConflictsTypeField {
        [Description("file")]
        File,
        [Description("folder")]
        Folder
    }
}