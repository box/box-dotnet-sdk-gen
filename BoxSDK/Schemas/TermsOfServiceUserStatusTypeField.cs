using System.ComponentModel;
using Serializer;
using System.Text.Json.Serialization;

namespace Box.Schemas {
    [JsonConverter(typeof(StringEnumConverter<TermsOfServiceUserStatusTypeField>))]
    public enum TermsOfServiceUserStatusTypeField {
        [Description("terms_of_service_user_status")]
        TermsOfServiceUserStatus
    }
}