using System.ComponentModel;
using Serializer;
using System.Text.Json.Serialization;

namespace Box.Schemas {
    [JsonConverter(typeof(StringEnumConverter<RetentionPolicyAssignmentTypeField>))]
    public enum RetentionPolicyAssignmentTypeField {
        [Description("retention_policy_assignment")]
        RetentionPolicyAssignment
    }
}