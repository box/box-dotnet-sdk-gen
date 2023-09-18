using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text.Json.Serialization;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class CreateLegalHoldPolicyAssignmentRequestBodyArg {
        /// <summary>
        /// The ID of the policy to assign.
        /// </summary>
        [JsonPropertyName("policy_id")]
        public string PolicyId { get; set; }

        /// <summary>
        /// The item to assign the policy to
        /// </summary>
        [JsonPropertyName("assign_to")]
        public CreateLegalHoldPolicyAssignmentRequestBodyArgAssignToField AssignTo { get; set; }

        public CreateLegalHoldPolicyAssignmentRequestBodyArg(string policyId, CreateLegalHoldPolicyAssignmentRequestBodyArgAssignToField assignTo) {
            PolicyId = policyId;
            AssignTo = assignTo;
        }
    }
}