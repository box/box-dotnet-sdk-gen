using System.ComponentModel;
using Serializer;
using System.Text.Json.Serialization;

namespace Box.Schemas {
    [JsonConverter(typeof(StringEnumConverter<SignRequestSignerSignerDecisionTypeField>))]
    public enum SignRequestSignerSignerDecisionTypeField {
        [Description("signed")]
        Signed,
        [Description("declined")]
        Declined
    }
}