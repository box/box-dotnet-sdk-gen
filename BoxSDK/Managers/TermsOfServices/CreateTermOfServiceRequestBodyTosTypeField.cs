using System.ComponentModel;
using Serializer;
using System.Text.Json.Serialization;
using Box.Schemas;
using Box;

namespace Box.Managers {
    [JsonConverter(typeof(StringEnumConverter<CreateTermOfServiceRequestBodyTosTypeField>))]
    public enum CreateTermOfServiceRequestBodyTosTypeField {
        [Description("external")]
        External,
        [Description("managed")]
        Managed
    }
}