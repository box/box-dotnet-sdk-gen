using System.ComponentModel;
using Serializer;
using System.Text.Json.Serialization;

namespace Box.Sdk.Gen.Schemas {
    [JsonConverter(typeof(StringEnumConverter<ShieldInformationBarrierSegmentRestrictionBaseTypeField>))]
    public enum ShieldInformationBarrierSegmentRestrictionBaseTypeField {
        [Description("shield_information_barrier_segment_restriction")]
        ShieldInformationBarrierSegmentRestriction
    }
}