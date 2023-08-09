using System.ComponentModel;
using Serializer;
using System.Text.Json.Serialization;
using Box.Schemas;
using Box;

namespace Box.Managers {
    [JsonConverter(typeof(StringEnumConverter<CreateTermOfServiceRequestBodyArgTosTypeField>))]
    public enum CreateTermOfServiceRequestBodyArgTosTypeField {
        [Description("external")]
        External,
        [Description("managed")]
        Managed
    }
}