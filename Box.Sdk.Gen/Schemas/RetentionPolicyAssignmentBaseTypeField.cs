using System.ComponentModel;
using Serializer;
using System.Text.Json.Serialization;

namespace Box.Sdk.Gen.Schemas {
    [JsonConverter(typeof(StringEnumConverter<RetentionPolicyAssignmentBaseTypeField>))]
    public enum RetentionPolicyAssignmentBaseTypeField {
        [Description("retention_policy_assignment")]
        RetentionPolicyAssignment
    }
}