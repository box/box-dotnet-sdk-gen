using System.ComponentModel;
using Serializer;
using System.Text.Json.Serialization;
using Box.Schemas;
using Box;

namespace Box.Managers {
    [JsonConverter(typeof(StringEnumConverter<CreateTermsOfServiceStatusForUserRequestBodyUserTypeField>))]
    public enum CreateTermsOfServiceStatusForUserRequestBodyUserTypeField {
        [Description("user")]
        User
    }
}