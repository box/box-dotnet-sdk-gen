using System.ComponentModel;
using Serializer;
using System.Text.Json.Serialization;

namespace Box.Schemas {
    [JsonConverter(typeof(StringEnumConverter<FileRequestStatusField>))]
    public enum FileRequestStatusField {
        [Description("active")]
        Active,
        [Description("inactive")]
        Inactive
    }
}