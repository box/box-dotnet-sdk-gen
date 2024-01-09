using System.ComponentModel;
using Serializer;
using System.Text.Json.Serialization;
using Box.Schemas;
using Box;

namespace Box.Managers {
    [JsonConverter(typeof(StringEnumConverter<CreateTermsOfServiceStatusForUserRequestBodyTosTypeField>))]
    public enum CreateTermsOfServiceStatusForUserRequestBodyTosTypeField {
        [Description("terms_of_service")]
        TermsOfService
    }
}