using System.ComponentModel;
using Serializer;
using System.Text.Json.Serialization;
using Box.Schemas;
using Box;

namespace Box.Managers {
    [JsonConverter(typeof(StringEnumConverter<CreateTermsOfServiceRequestBodyTosTypeField>))]
    public enum CreateTermsOfServiceRequestBodyTosTypeField {
        [Description("external")]
        External,
        [Description("managed")]
        Managed
    }
}