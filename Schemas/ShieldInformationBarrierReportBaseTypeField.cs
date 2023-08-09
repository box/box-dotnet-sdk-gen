using System.ComponentModel;
using Serializer;
using System.Text.Json.Serialization;

namespace Box.Schemas {
    [JsonConverter(typeof(StringEnumConverter<ShieldInformationBarrierReportBaseTypeField>))]
    public enum ShieldInformationBarrierReportBaseTypeField {
        [Description("shield_information_barrier_report")]
        ShieldInformationBarrierReport
    }
}