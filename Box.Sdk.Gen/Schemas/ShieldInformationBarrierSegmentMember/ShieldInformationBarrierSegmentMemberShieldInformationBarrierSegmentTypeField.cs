using System.ComponentModel;
using Serializer;
using System.Text.Json.Serialization;
using Box.Sdk.Gen.Schemas;

namespace Box.Sdk.Gen.Schemas {
    [JsonConverter(typeof(StringEnumConverter<ShieldInformationBarrierSegmentMemberShieldInformationBarrierSegmentTypeField>))]
    public enum ShieldInformationBarrierSegmentMemberShieldInformationBarrierSegmentTypeField {
        [Description("shield_information_barrier_segment")]
        ShieldInformationBarrierSegment
    }
}