using System.ComponentModel;
using Serializer;
using System.Text.Json.Serialization;
using Box.Schemas;
using Box;

namespace Box.Managers {
    [JsonConverter(typeof(StringEnumConverter<UpdateShieldInformationBarrierStatusRequestBodyStatusField>))]
    public enum UpdateShieldInformationBarrierStatusRequestBodyStatusField {
        [Description("pending")]
        Pending,
        [Description("disabled")]
        Disabled
    }
}