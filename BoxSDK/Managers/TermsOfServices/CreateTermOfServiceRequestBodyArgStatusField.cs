using System.ComponentModel;
using Serializer;
using System.Text.Json.Serialization;
using Box.Schemas;
using Box;

namespace Box.Managers {
    [JsonConverter(typeof(StringEnumConverter<CreateTermOfServiceRequestBodyArgStatusField>))]
    public enum CreateTermOfServiceRequestBodyArgStatusField {
        [Description("enabled")]
        Enabled,
        [Description("disabled")]
        Disabled
    }
}