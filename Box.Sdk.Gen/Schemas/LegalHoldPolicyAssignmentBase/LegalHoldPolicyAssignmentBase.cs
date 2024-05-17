using Unions;
using System.Text.Json.Serialization;

namespace Box.Sdk.Gen.Schemas {
    public class LegalHoldPolicyAssignmentBase {
        /// <summary>
        /// The unique identifier for this legal hold assignment
        /// </summary>
        [JsonPropertyName("id")]
        public string? Id { get; init; }

        /// <summary>
        /// `legal_hold_policy_assignment`
        /// </summary>
        [JsonPropertyName("type")]
        public LegalHoldPolicyAssignmentBaseTypeField? Type { get; init; }

        public LegalHoldPolicyAssignmentBase() {
            
        }
    }
}