using System.ComponentModel;
using Serializer;
using System.Text.Json.Serialization;

namespace Box.Sdk.Gen.Schemas {
    [JsonConverter(typeof(StringEnumConverter<TermsOfServiceEnterpriseTypeField>))]
    public enum TermsOfServiceEnterpriseTypeField {
        [Description("enterprise")]
        Enterprise
    }
}