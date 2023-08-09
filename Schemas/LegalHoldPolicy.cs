using System.IO;
using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;

namespace Box.Schemas {
    public class LegalHoldPolicy : LegalHoldPolicyMini {
        [JsonPropertyName("policy_name")]
        public string PolicyName { get; }

        [JsonPropertyName("description")]
        public string Description { get; }

        [JsonPropertyName("status")]
        public LegalHoldPolicyStatusField Status { get; }

        [JsonPropertyName("assignment_counts")]
        public LegalHoldPolicyAssignmentCountsField AssignmentCounts { get; }

        [JsonPropertyName("created_by")]
        public UserMini CreatedBy { get; }

        [JsonPropertyName("created_at")]
        public string CreatedAt { get; }

        [JsonPropertyName("modified_at")]
        public string ModifiedAt { get; }

        [JsonPropertyName("deleted_at")]
        public string DeletedAt { get; }

        [JsonPropertyName("filter_started_at")]
        public string FilterStartedAt { get; }

        [JsonPropertyName("filter_ended_at")]
        public string FilterEndedAt { get; }

        [JsonPropertyName("release_notes")]
        public string ReleaseNotes { get; }

        public LegalHoldPolicy(string id, LegalHoldPolicyMiniTypeField type, string policyName, string description, LegalHoldPolicyStatusField status, LegalHoldPolicyAssignmentCountsField assignmentCounts, UserMini createdBy, string createdAt, string modifiedAt, string deletedAt, string filterStartedAt, string filterEndedAt, string releaseNotes) : base(id, type) {
            PolicyName = policyName;
            Description = description;
            Status = status;
            AssignmentCounts = assignmentCounts;
            CreatedBy = createdBy;
            CreatedAt = createdAt;
            ModifiedAt = modifiedAt;
            DeletedAt = deletedAt;
            FilterStartedAt = filterStartedAt;
            FilterEndedAt = filterEndedAt;
            ReleaseNotes = releaseNotes;
        }
    }
}