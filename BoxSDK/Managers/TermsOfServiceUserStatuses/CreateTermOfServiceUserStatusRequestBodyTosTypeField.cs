using System.ComponentModel;
using Serializer;
using System.Text.Json.Serialization;
using Box.Schemas;
using Box;

namespace Box.Managers {
    [JsonConverter(typeof(StringEnumConverter<CreateTermOfServiceUserStatusRequestBodyTosTypeField>))]
    public enum CreateTermOfServiceUserStatusRequestBodyTosTypeField {
        [Description("terms_of_service")]
        TermsOfService
    }
}