using System.ComponentModel;
using Serializer;
using System.Text.Json.Serialization;

namespace Box.Sdk.Gen.Schemas {
    [JsonConverter(typeof(StringEnumConverter<SignRequestTypeField>))]
    public enum SignRequestTypeField {
        [Description("sign-request")]
        SignRequest
    }
}