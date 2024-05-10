using System.ComponentModel;
using Serializer;
using System.Text.Json.Serialization;

namespace Box.Sdk.Gen.Schemas {
    [JsonConverter(typeof(StringEnumConverter<ShieldInformationBarrierBaseTypeField>))]
    public enum ShieldInformationBarrierBaseTypeField {
        [Description("shield_information_barrier")]
        ShieldInformationBarrier
    }
}