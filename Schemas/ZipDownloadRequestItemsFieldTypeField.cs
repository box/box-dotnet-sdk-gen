using System.ComponentModel;
using Serializer;
using System.Text.Json.Serialization;

namespace Box.Schemas {
    [JsonConverter(typeof(StringEnumConverter<ZipDownloadRequestItemsFieldTypeField>))]
    public enum ZipDownloadRequestItemsFieldTypeField {
        [Description("file")]
        File,
        [Description("folder.")]
        Folder
    }
}