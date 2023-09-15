using System.ComponentModel;
using Serializer;
using System.Text.Json.Serialization;

namespace Box.Schemas {
    [JsonConverter(typeof(StringEnumConverter<SignTemplateAdditionalInfoFieldRequiredFieldSignersField>))]
    public enum SignTemplateAdditionalInfoFieldRequiredFieldSignersField {
        [Description("email")]
        Email
    }
}