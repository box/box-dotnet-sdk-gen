using Unions;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class CreateLegalHoldPolicyAssignmentRequestBody {
        /// <summary>
        /// The ID of the policy to assign.
        /// </summary>
        [JsonPropertyName("policy_id")]
        public string PolicyId { get; set; }

        /// <summary>
        /// The item to assign the policy to
        /// </summary>
        [JsonPropertyName("assign_to")]
        public CreateLegalHoldPolicyAssignmentRequestBodyAssignToField AssignTo { get; set; }

        public CreateLegalHoldPolicyAssignmentRequestBody(string policyId, CreateLegalHoldPolicyAssignmentRequestBodyAssignToField assignTo) {
            PolicyId = policyId;
            AssignTo = assignTo;
        }
    }
}