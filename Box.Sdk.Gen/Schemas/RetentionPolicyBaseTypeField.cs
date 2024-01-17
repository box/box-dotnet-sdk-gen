using System.ComponentModel;
using Serializer;
using System.Text.Json.Serialization;

namespace Box.Sdk.Gen.Schemas {
    [JsonConverter(typeof(StringEnumConverter<RetentionPolicyBaseTypeField>))]
    public enum RetentionPolicyBaseTypeField {
        [Description("retention_policy")]
        RetentionPolicy
    }
}