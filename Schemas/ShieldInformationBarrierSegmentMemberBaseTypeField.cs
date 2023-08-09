using System.ComponentModel;
using Serializer;
using System.Text.Json.Serialization;

namespace Box.Schemas {
    [JsonConverter(typeof(StringEnumConverter<ShieldInformationBarrierSegmentMemberBaseTypeField>))]
    public enum ShieldInformationBarrierSegmentMemberBaseTypeField {
        [Description("shield_information_barrier_segment_member")]
        ShieldInformationBarrierSegmentMember
    }
}