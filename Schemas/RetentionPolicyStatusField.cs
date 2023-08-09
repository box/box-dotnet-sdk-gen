using System.ComponentModel;
using Serializer;
using System.Text.Json.Serialization;

namespace Box.Schemas {
    [JsonConverter(typeof(StringEnumConverter<RetentionPolicyStatusField>))]
    public enum RetentionPolicyStatusField {
        [Description("active")]
        Active,
        [Description("retired")]
        Retired
    }
}