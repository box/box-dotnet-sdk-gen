using System.ComponentModel;
using Serializer;
using System.Text.Json.Serialization;
using Box.Sdk.Gen.Schemas;

namespace Box.Sdk.Gen.Schemas {
    [JsonConverter(typeof(StringEnumConverter<ShieldInformationBarrierTypeField>))]
    public enum ShieldInformationBarrierTypeField {
        [Description("shield_information_barrier")]
        ShieldInformationBarrier
    }
}