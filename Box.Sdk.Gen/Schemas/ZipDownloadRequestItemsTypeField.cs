using System.ComponentModel;
using Serializer;
using System.Text.Json.Serialization;

namespace Box.Sdk.Gen.Schemas {
    [JsonConverter(typeof(StringEnumConverter<ZipDownloadRequestItemsTypeField>))]
    public enum ZipDownloadRequestItemsTypeField {
        [Description("file")]
        File,
        [Description("folder")]
        Folder
    }
}