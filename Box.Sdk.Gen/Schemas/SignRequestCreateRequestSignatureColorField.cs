using System.ComponentModel;
using Serializer;
using System.Text.Json.Serialization;

namespace Box.Sdk.Gen.Schemas {
    [JsonConverter(typeof(StringEnumConverter<SignRequestCreateRequestSignatureColorField>))]
    public enum SignRequestCreateRequestSignatureColorField {
        [Description("blue")]
        Blue,
        [Description("black")]
        Black,
        [Description("red")]
        Red
    }
}