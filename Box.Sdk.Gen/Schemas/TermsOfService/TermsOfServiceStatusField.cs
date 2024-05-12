using System.ComponentModel;
using Serializer;
using System.Text.Json.Serialization;
using Box.Sdk.Gen.Schemas;

namespace Box.Sdk.Gen.Schemas {
    [JsonConverter(typeof(StringEnumConverter<TermsOfServiceStatusField>))]
    public enum TermsOfServiceStatusField {
        [Description("enabled")]
        Enabled,
        [Description("disabled")]
        Disabled
    }
}