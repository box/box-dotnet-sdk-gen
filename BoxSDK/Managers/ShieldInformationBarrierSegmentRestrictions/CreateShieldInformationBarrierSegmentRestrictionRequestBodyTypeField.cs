using System.ComponentModel;
using Serializer;
using System.Text.Json.Serialization;
using Box.Schemas;
using Box;

namespace Box.Managers {
    [JsonConverter(typeof(StringEnumConverter<CreateShieldInformationBarrierSegmentRestrictionRequestBodyTypeField>))]
    public enum CreateShieldInformationBarrierSegmentRestrictionRequestBodyTypeField {
        [Description("shield_information_barrier_segment_restriction")]
        ShieldInformationBarrierSegmentRestriction
    }
}