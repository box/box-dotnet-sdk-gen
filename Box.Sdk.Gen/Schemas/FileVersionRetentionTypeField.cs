using System.ComponentModel;
using Serializer;
using System.Text.Json.Serialization;

namespace Box.Sdk.Gen.Schemas {
    [JsonConverter(typeof(StringEnumConverter<FileVersionRetentionTypeField>))]
    public enum FileVersionRetentionTypeField {
        [Description("file_version_retention")]
        FileVersionRetention
    }
}