using System.ComponentModel;
using Serializer;
using System.Text.Json.Serialization;

namespace Box.Schemas {
    [JsonConverter(typeof(StringEnumConverter<SignTemplateAdditionalInfoRequiredSignersField>))]
    public enum SignTemplateAdditionalInfoRequiredSignersField {
        [Description("email")]
        Email
    }
}