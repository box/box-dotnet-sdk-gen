using System.ComponentModel;
using Serializer;
using System.Text.Json.Serialization;

namespace Box.Sdk.Gen.Schemas {
    [JsonConverter(typeof(StringEnumConverter<FileRequestUpdateRequestStatusField>))]
    public enum FileRequestUpdateRequestStatusField {
        [Description("active")]
        Active,
        [Description("inactive")]
        Inactive
    }
}