using System.ComponentModel;
using Serializer;
using System.Text.Json.Serialization;

namespace Box.Schemas {
    [JsonConverter(typeof(StringEnumConverter<SignRequestSignerSignerDecisionFieldTypeField>))]
    public enum SignRequestSignerSignerDecisionFieldTypeField {
        [Description("signed")]
        Signed,
        [Description("declined")]
        Declined
    }
}