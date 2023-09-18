using System.ComponentModel;
using Serializer;
using System.Text.Json.Serialization;

namespace Box.Schemas {
    [JsonConverter(typeof(StringEnumConverter<RetentionPolicyPolicyTypeField>))]
    public enum RetentionPolicyPolicyTypeField {
        [Description("finite")]
        Finite,
        [Description("indefinite")]
        Indefinite
    }
}