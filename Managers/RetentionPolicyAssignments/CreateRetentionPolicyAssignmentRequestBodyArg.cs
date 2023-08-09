using System.IO;
using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text.Json.Serialization;
using System;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class CreateRetentionPolicyAssignmentRequestBodyArg {
        [JsonPropertyName("policy_id")]
        public string PolicyId { get; }

        [JsonPropertyName("assign_to")]
        public CreateRetentionPolicyAssignmentRequestBodyArgAssignToField AssignTo { get; }

        [JsonPropertyName("filter_fields")]
        public IReadOnlyList<CreateRetentionPolicyAssignmentRequestBodyArgFilterFieldsField> FilterFields { get; }

        [JsonPropertyName("start_date_field")]
        public string StartDateField { get; }

        public CreateRetentionPolicyAssignmentRequestBodyArg(string policyId, CreateRetentionPolicyAssignmentRequestBodyArgAssignToField assignTo, IReadOnlyList<CreateRetentionPolicyAssignmentRequestBodyArgFilterFieldsField> filterFields, string startDateField) {
            PolicyId = policyId;
            AssignTo = assignTo;
            FilterFields = filterFields;
            StartDateField = startDateField;
        }
    }
}