using System.ComponentModel;
using Serializer;
using System.Text.Json.Serialization;

namespace Box.Sdk.Gen.Schemas {
    [JsonConverter(typeof(StringEnumConverter<FileVersionLegalHoldTypeField>))]
    public enum FileVersionLegalHoldTypeField {
        [Description("file_version_legal_hold")]
        FileVersionLegalHold
    }
}