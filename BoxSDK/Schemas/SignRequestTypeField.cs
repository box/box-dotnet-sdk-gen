using System.ComponentModel;
using Serializer;
using System.Text.Json.Serialization;

namespace Box.Schemas {
    [JsonConverter(typeof(StringEnumConverter<SignRequestTypeField>))]
    public enum SignRequestTypeField {
        [Description("sign-request")]
        SignRequest
    }
}