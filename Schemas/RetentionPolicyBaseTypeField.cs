using System.ComponentModel;
using Serializer;
using System.Text.Json.Serialization;

namespace Box.Schemas {
    [JsonConverter(typeof(StringEnumConverter<RetentionPolicyBaseTypeField>))]
    public enum RetentionPolicyBaseTypeField {
        [Description("retention_policy")]
        RetentionPolicy
    }
}