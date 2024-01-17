using System.ComponentModel;
using Serializer;
using System.Text.Json.Serialization;

namespace Box.Sdk.Gen.Schemas {
    [JsonConverter(typeof(StringEnumConverter<DevicePinnersOrderDirectionField>))]
    public enum DevicePinnersOrderDirectionField {
        [Description("asc")]
        Asc,
        [Description("desc")]
        Desc
    }
}