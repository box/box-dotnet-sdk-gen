using System.IO;
using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text.Json.Serialization;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class CreateLegalHoldPolicyAssignmentRequestBodyArg {
        [JsonPropertyName("policy_id")]
        public string PolicyId { get; }

        [JsonPropertyName("assign_to")]
        public CreateLegalHoldPolicyAssignmentRequestBodyArgAssignToField AssignTo { get; }

        public CreateLegalHoldPolicyAssignmentRequestBodyArg(string policyId, CreateLegalHoldPolicyAssignmentRequestBodyArgAssignToField assignTo) {
            PolicyId = policyId;
            AssignTo = assignTo;
        }
    }
}