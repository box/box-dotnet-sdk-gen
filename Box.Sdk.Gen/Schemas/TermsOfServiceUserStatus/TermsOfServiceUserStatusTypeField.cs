using System.ComponentModel;
using Serializer;
using System.Text.Json.Serialization;
using Box.Sdk.Gen.Schemas;

namespace Box.Sdk.Gen.Schemas {
    [JsonConverter(typeof(StringEnumConverter<TermsOfServiceUserStatusTypeField>))]
    public enum TermsOfServiceUserStatusTypeField {
        [Description("terms_of_service_user_status")]
        TermsOfServiceUserStatus
    }
}