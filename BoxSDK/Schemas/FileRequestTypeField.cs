using System.ComponentModel;
using Serializer;
using System.Text.Json.Serialization;

namespace Box.Schemas {
    [JsonConverter(typeof(StringEnumConverter<FileRequestTypeField>))]
    public enum FileRequestTypeField {
        [Description("file_request")]
        FileRequest
    }
}