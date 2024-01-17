using System.ComponentModel;
using Serializer;
using System.Text.Json.Serialization;

namespace Box.Sdk.Gen.Schemas {
    [JsonConverter(typeof(StringEnumConverter<TermsOfServiceBaseTypeField>))]
    public enum TermsOfServiceBaseTypeField {
        [Description("terms_of_service")]
        TermsOfService
    }
}