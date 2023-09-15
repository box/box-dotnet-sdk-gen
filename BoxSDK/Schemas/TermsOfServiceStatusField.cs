using System.ComponentModel;
using Serializer;
using System.Text.Json.Serialization;

namespace Box.Schemas {
    [JsonConverter(typeof(StringEnumConverter<TermsOfServiceStatusField>))]
    public enum TermsOfServiceStatusField {
        [Description("enabled")]
        Enabled,
        [Description("disabled")]
        Disabled
    }
}