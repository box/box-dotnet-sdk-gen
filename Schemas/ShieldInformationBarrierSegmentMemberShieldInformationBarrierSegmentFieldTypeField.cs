using System.ComponentModel;
using Serializer;
using System.Text.Json.Serialization;

namespace Box.Schemas {
    [JsonConverter(typeof(StringEnumConverter<ShieldInformationBarrierSegmentMemberShieldInformationBarrierSegmentFieldTypeField>))]
    public enum ShieldInformationBarrierSegmentMemberShieldInformationBarrierSegmentFieldTypeField {
        [Description("shield_information_barrier_segment")]
        ShieldInformationBarrierSegment
    }
}