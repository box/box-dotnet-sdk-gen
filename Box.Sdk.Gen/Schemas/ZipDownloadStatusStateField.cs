using System.ComponentModel;
using Serializer;
using System.Text.Json.Serialization;

namespace Box.Sdk.Gen.Schemas {
    [JsonConverter(typeof(StringEnumConverter<ZipDownloadStatusStateField>))]
    public enum ZipDownloadStatusStateField {
        [Description("in_progress")]
        InProgress,
        [Description("failed")]
        Failed,
        [Description("succeeded")]
        Succeeded
    }
}