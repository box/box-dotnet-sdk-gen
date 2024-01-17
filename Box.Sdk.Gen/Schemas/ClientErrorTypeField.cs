using System.ComponentModel;
using Serializer;
using System.Text.Json.Serialization;

namespace Box.Sdk.Gen.Schemas {
    [JsonConverter(typeof(StringEnumConverter<ClientErrorTypeField>))]
    public enum ClientErrorTypeField {
        [Description("error")]
        Error
    }
}