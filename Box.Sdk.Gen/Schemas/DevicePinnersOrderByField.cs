using System.ComponentModel;
using Serializer;
using System.Text.Json.Serialization;

namespace Box.Sdk.Gen.Schemas {
    [JsonConverter(typeof(StringEnumConverter<DevicePinnersOrderByField>))]
    public enum DevicePinnersOrderByField {
        [Description("id")]
        Id
    }
}