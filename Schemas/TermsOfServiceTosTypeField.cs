using System.ComponentModel;
using Serializer;
using System.Text.Json.Serialization;

namespace Box.Schemas {
    [JsonConverter(typeof(StringEnumConverter<TermsOfServiceTosTypeField>))]
    public enum TermsOfServiceTosTypeField {
        [Description("managed")]
        Managed,
        [Description("external")]
        External
    }
}