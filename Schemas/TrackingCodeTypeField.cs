using System.ComponentModel;
using Serializer;
using System.Text.Json.Serialization;

namespace Box.Schemas {
    [JsonConverter(typeof(StringEnumConverter<TrackingCodeTypeField>))]
    public enum TrackingCodeTypeField {
        [Description("tracking_code")]
        TrackingCode
    }
}