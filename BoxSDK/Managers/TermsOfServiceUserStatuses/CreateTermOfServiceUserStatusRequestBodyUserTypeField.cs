using System.ComponentModel;
using Serializer;
using System.Text.Json.Serialization;
using Box.Schemas;
using Box;

namespace Box.Managers {
    [JsonConverter(typeof(StringEnumConverter<CreateTermOfServiceUserStatusRequestBodyUserTypeField>))]
    public enum CreateTermOfServiceUserStatusRequestBodyUserTypeField {
        [Description("user")]
        User
    }
}