using Box.Sdk.Gen;
using System.Text.Json.Serialization;
using Box.Sdk.Gen.Internal;
using Box.Sdk.Gen.Schemas;

namespace Box.Sdk.Gen.Schemas {
    public class RetentionPolicyAssignmentAssignedToField {
        /// <summary>
        /// The ID of the folder, enterprise, or metadata template
        /// the policy is assigned to.
        /// Set to null or omit when type is set to enterprise.
        /// </summary>
        [JsonPropertyName("id")]
        public string? Id { get; init; }

        /// <summary>
        /// The type of resource the policy is assigned to.
        /// </summary>
        [JsonPropertyName("type")]
        [JsonConverter(typeof(StringEnumConverter<RetentionPolicyAssignmentAssignedToTypeField>))]
        public StringEnum<RetentionPolicyAssignmentAssignedToTypeField>? Type { get; init; }

        public RetentionPolicyAssignmentAssignedToField() {
            
        }
    }
}