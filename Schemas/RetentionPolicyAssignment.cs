using System.IO;
using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;

namespace Box.Schemas {
    public class RetentionPolicyAssignment {
        [JsonPropertyName("id")]
        public string Id { get; }

        [JsonPropertyName("type")]
        public RetentionPolicyAssignmentTypeField Type { get; }

        [JsonPropertyName("retention_policy")]
        public RetentionPolicyMini RetentionPolicy { get; }

        [JsonPropertyName("assigned_to")]
        public RetentionPolicyAssignmentAssignedToField AssignedTo { get; }

        [JsonPropertyName("filter_fields")]
        public IReadOnlyList<RetentionPolicyAssignmentFilterFieldsField> FilterFields { get; }

        [JsonPropertyName("assigned_by")]
        public UserMini AssignedBy { get; }

        [JsonPropertyName("assigned_at")]
        public string AssignedAt { get; }

        [JsonPropertyName("start_date_field")]
        public string StartDateField { get; }

        public RetentionPolicyAssignment(string id, RetentionPolicyAssignmentTypeField type, RetentionPolicyMini retentionPolicy, RetentionPolicyAssignmentAssignedToField assignedTo, IReadOnlyList<RetentionPolicyAssignmentFilterFieldsField> filterFields, UserMini assignedBy, string assignedAt, string startDateField) {
            Id = id;
            Type = type;
            RetentionPolicy = retentionPolicy;
            AssignedTo = assignedTo;
            FilterFields = filterFields;
            AssignedBy = assignedBy;
            AssignedAt = assignedAt;
            StartDateField = startDateField;
        }
    }
}