using System.ComponentModel;
using Serializer;
using System.Text.Json.Serialization;

namespace Box.Schemas {
    [JsonConverter(typeof(StringEnumConverter<FileBaseTypeField>))]
    public enum FileBaseTypeField {
        [Description("file")]
        File
    }
}