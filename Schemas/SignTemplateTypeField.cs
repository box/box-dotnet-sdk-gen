using System.ComponentModel;
using Serializer;
using System.Text.Json.Serialization;

namespace Box.Schemas {
    [JsonConverter(typeof(StringEnumConverter<SignTemplateTypeField>))]
    public enum SignTemplateTypeField {
        [Description("sign-template")]
        SignTemplate
    }
}