using Unions;
using Box.Sdk.Gen;
using System.Text.Json.Serialization;
using Serializer;

namespace Box.Sdk.Gen.Schemas {
    public class RetentionPolicyAssignmentBase {
        /// <summary>
        /// The unique identifier that represents a file version.
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; }

        /// <summary>
        /// `retention_policy_assignment`
        /// </summary>
        [JsonPropertyName("type")]
        [JsonConverter(typeof(StringEnumConverter<RetentionPolicyAssignmentBaseTypeField>))]
        public StringEnum<RetentionPolicyAssignmentBaseTypeField> Type { get; }

        public RetentionPolicyAssignmentBase(string id, RetentionPolicyAssignmentBaseTypeField type = RetentionPolicyAssignmentBaseTypeField.RetentionPolicyAssignment) {
            Id = id;
            Type = type;
        }
        
        [JsonConstructorAttribute]
        internal RetentionPolicyAssignmentBase(string id, StringEnum<RetentionPolicyAssignmentBaseTypeField> type) {
            Id = id;
            Type = RetentionPolicyAssignmentBaseTypeField.RetentionPolicyAssignment;
        }
    }
}