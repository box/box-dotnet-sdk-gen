using System.ComponentModel;
using Serializer;
using System.Text.Json.Serialization;

namespace Box.Sdk.Gen.Schemas {
    [JsonConverter(typeof(StringEnumConverter<DevicePinnerTypeField>))]
    public enum DevicePinnerTypeField {
        [Description("device_pinner")]
        DevicePinner
    }
}