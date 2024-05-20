using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using Box.Sdk.Gen.Schemas;

namespace Box.Sdk.Gen.Schemas {
    public class RetentionPolicyAssignment {
        /// <summary>
        /// The unique identifier for a retention policy assignment.
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; }

        /// <summary>
        /// `retention_policy_assignment`
        /// </summary>
        [JsonPropertyName("type")]
        public RetentionPolicyAssignmentTypeField Type { get; }

        [JsonPropertyName("retention_policy")]
        public RetentionPolicyMini? RetentionPolicy { get; init; }

        /// <summary>
        /// The `type` and `id` of the content that is under
        /// retention. The `type` can either be `folder`
        /// `enterprise`, or `metadata_template`.
        /// </summary>
        [JsonPropertyName("assigned_to")]
        public RetentionPolicyAssignmentAssignedToField? AssignedTo { get; init; }

        /// <summary>
        /// An array of field objects. Values are only returned if the `assigned_to`
        /// type is `metadata_template`. Otherwise, the array is blank.
        /// </summary>
        [JsonPropertyName("filter_fields")]
        public IReadOnlyList<RetentionPolicyAssignmentFilterFieldsField>? FilterFields { get; init; }

        [JsonPropertyName("assigned_by")]
        public UserMini? AssignedBy { get; init; }

        /// <summary>
        /// When the retention policy assignment object was
        /// created.
        /// </summary>
        [JsonPropertyName("assigned_at")]
        public System.DateTimeOffset? AssignedAt { get; init; }

        /// <summary>
        /// The date the retention policy assignment begins.
        /// If the `assigned_to` type is `metadata_template`,
        /// this field can be a date field's metadata attribute key id.
        /// </summary>
        [JsonPropertyName("start_date_field")]
        public string? StartDateField { get; init; }

        public RetentionPolicyAssignment(string id, RetentionPolicyAssignmentTypeField type = RetentionPolicyAssignmentTypeField.RetentionPolicyAssignment) {
            Id = id;
            Type = type;
        }
    }
}