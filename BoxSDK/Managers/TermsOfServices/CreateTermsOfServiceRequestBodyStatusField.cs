using System.ComponentModel;
using Serializer;
using System.Text.Json.Serialization;
using Box.Schemas;
using Box;

namespace Box.Managers {
    [JsonConverter(typeof(StringEnumConverter<CreateTermsOfServiceRequestBodyStatusField>))]
    public enum CreateTermsOfServiceRequestBodyStatusField {
        [Description("enabled")]
        Enabled,
        [Description("disabled")]
        Disabled
    }
}