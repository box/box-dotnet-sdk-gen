using System.ComponentModel;
using Serializer;
using System.Text.Json.Serialization;
using Box.Schemas;
using Box;

namespace Box.Managers {
    [JsonConverter(typeof(StringEnumConverter<UpdateTermsOfServiceByIdRequestBodyStatusField>))]
    public enum UpdateTermsOfServiceByIdRequestBodyStatusField {
        [Description("enabled")]
        Enabled,
        [Description("disabled")]
        Disabled
    }
}