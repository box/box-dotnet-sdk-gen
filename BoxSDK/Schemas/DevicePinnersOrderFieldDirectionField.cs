using System.ComponentModel;
using Serializer;
using System.Text.Json.Serialization;

namespace Box.Schemas {
    [JsonConverter(typeof(StringEnumConverter<DevicePinnersOrderFieldDirectionField>))]
    public enum DevicePinnersOrderFieldDirectionField {
        [Description("asc")]
        Asc,
        [Description("desc")]
        Desc
    }
}