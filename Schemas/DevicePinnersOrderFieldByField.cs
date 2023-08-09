using System.ComponentModel;
using Serializer;
using System.Text.Json.Serialization;

namespace Box.Schemas {
    [JsonConverter(typeof(StringEnumConverter<DevicePinnersOrderFieldByField>))]
    public enum DevicePinnersOrderFieldByField {
        [Description("id")]
        Id
    }
}