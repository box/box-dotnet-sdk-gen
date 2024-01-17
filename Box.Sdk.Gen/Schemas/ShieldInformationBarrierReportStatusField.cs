using System.ComponentModel;
using Serializer;
using System.Text.Json.Serialization;

namespace Box.Sdk.Gen.Schemas {
    [JsonConverter(typeof(StringEnumConverter<ShieldInformationBarrierReportStatusField>))]
    public enum ShieldInformationBarrierReportStatusField {
        [Description("pending")]
        Pending,
        [Description("error")]
        Error,
        [Description("done")]
        Done,
        [Description("cancelled")]
        Cancelled
    }
}