using System.ComponentModel;
using Serializer;
using System.Text.Json.Serialization;

namespace Box.Sdk.Gen.Schemas {
    [JsonConverter(typeof(StringEnumConverter<RetentionPolicyAssignmentTypeField>))]
    public enum RetentionPolicyAssignmentTypeField {
        [Description("retention_policy_assignment")]
        RetentionPolicyAssignment
    }
}