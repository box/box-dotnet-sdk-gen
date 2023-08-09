using System.ComponentModel;
using Serializer;
using System.Text.Json.Serialization;

namespace Box.Schemas {
    [JsonConverter(typeof(StringEnumConverter<ShieldInformationBarrierSegmentRestrictionMiniRestrictedSegmentFieldTypeField>))]
    public enum ShieldInformationBarrierSegmentRestrictionMiniRestrictedSegmentFieldTypeField {
        [Description("shield_information_barrier_segment")]
        ShieldInformationBarrierSegment
    }
}