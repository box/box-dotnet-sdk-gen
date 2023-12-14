using System.ComponentModel;
using Serializer;
using System.Text.Json.Serialization;
using Box.Schemas;
using Box;

namespace Box.Managers {
    [JsonConverter(typeof(StringEnumConverter<CreateShieldInformationBarrierChangeStatusRequestBodyStatusField>))]
    public enum CreateShieldInformationBarrierChangeStatusRequestBodyStatusField {
        [Description("pending")]
        Pending,
        [Description("disabled")]
        Disabled
    }
}