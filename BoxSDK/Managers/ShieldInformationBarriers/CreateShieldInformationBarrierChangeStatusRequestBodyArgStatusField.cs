using System.ComponentModel;
using Serializer;
using System.Text.Json.Serialization;
using Box.Schemas;
using Box;

namespace Box.Managers {
    [JsonConverter(typeof(StringEnumConverter<CreateShieldInformationBarrierChangeStatusRequestBodyArgStatusField>))]
    public enum CreateShieldInformationBarrierChangeStatusRequestBodyArgStatusField {
        [Description("pending")]
        Pending,
        [Description("disabled")]
        Disabled
    }
}