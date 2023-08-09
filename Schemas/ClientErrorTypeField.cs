using System.ComponentModel;
using Serializer;
using System.Text.Json.Serialization;

namespace Box.Schemas {
    [JsonConverter(typeof(StringEnumConverter<ClientErrorTypeField>))]
    public enum ClientErrorTypeField {
        [Description("error")]
        Error
    }
}