using System.ComponentModel;
using Serializer;
using System.Text.Json.Serialization;

namespace Box.Sdk.Gen.Schemas {
    [JsonConverter(typeof(StringEnumConverter<SignTemplateAdditionalInfoRequiredSignersField>))]
    public enum SignTemplateAdditionalInfoRequiredSignersField {
        [Description("email")]
        Email
    }
}