using System.ComponentModel;
using Serializer;
using System.Text.Json.Serialization;
using Box.Schemas;
using Box;

namespace Box.Managers {
    [JsonConverter(typeof(StringEnumConverter<CreateTermOfServiceUserStatusRequestBodyArgTosFieldTypeField>))]
    public enum CreateTermOfServiceUserStatusRequestBodyArgTosFieldTypeField {
        [Description("terms_of_service")]
        TermsOfService
    }
}