using System.ComponentModel;
using Serializer;
using System.Text.Json.Serialization;

namespace Box.Sdk.Gen.Schemas {
    [JsonConverter(typeof(StringEnumConverter<FileVersionBaseTypeField>))]
    public enum FileVersionBaseTypeField {
        [Description("file_version")]
        FileVersion
    }
}