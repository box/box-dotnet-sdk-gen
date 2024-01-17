using System.ComponentModel;
using Serializer;
using System.Text.Json.Serialization;

namespace Box.Sdk.Gen.Schemas {
    [JsonConverter(typeof(StringEnumConverter<ShieldInformationBarrierSegmentRestrictionMiniShieldInformationBarrierSegmentTypeField>))]
    public enum ShieldInformationBarrierSegmentRestrictionMiniShieldInformationBarrierSegmentTypeField {
        [Description("shield_information_barrier_segment")]
        ShieldInformationBarrierSegment
    }
}