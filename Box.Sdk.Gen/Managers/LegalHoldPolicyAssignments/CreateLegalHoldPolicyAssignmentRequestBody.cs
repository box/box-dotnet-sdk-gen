using Unions;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Box.Sdk.Gen.Schemas;
using Box.Sdk.Gen;

namespace Box.Sdk.Gen.Managers {
    public class CreateLegalHoldPolicyAssignmentRequestBody {
        /// <summary>
        /// The ID of the policy to assign.
        /// </summary>
        [JsonPropertyName("policy_id")]
        public string PolicyId { get; }

        /// <summary>
        /// The item to assign the policy to
        /// </summary>
        [JsonPropertyName("assign_to")]
        public CreateLegalHoldPolicyAssignmentRequestBodyAssignToField AssignTo { get; }

        public CreateLegalHoldPolicyAssignmentRequestBody(string policyId, CreateLegalHoldPolicyAssignmentRequestBodyAssignToField assignTo) {
            PolicyId = policyId;
            AssignTo = assignTo;
        }
    }
}