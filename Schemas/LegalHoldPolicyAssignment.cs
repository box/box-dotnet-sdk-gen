using System.IO;
using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Text.Json;

namespace Box.Schemas {
    public class LegalHoldPolicyAssignment : LegalHoldPolicyAssignmentBase {
        [JsonPropertyName("legal_hold_policy")]
        public LegalHoldPolicyMini LegalHoldPolicy { get; }

        [JsonPropertyName("assigned_to")]
        public LegalHoldPolicyAssignmentAssignedToField AssignedTo { get; }

        [JsonPropertyName("assigned_by")]
        public UserMini AssignedBy { get; }

        [JsonPropertyName("assigned_at")]
        public string AssignedAt { get; }

        [JsonPropertyName("deleted_at")]
        public string DeletedAt { get; }

        public LegalHoldPolicyAssignment(string id, LegalHoldPolicyAssignmentBaseTypeField type, LegalHoldPolicyMini legalHoldPolicy, LegalHoldPolicyAssignmentAssignedToField assignedTo, UserMini assignedBy, string assignedAt, string deletedAt) : base(id, type) {
            LegalHoldPolicy = legalHoldPolicy;
            AssignedTo = assignedTo;
            AssignedBy = assignedBy;
            AssignedAt = assignedAt;
            DeletedAt = deletedAt;
        }
    }
}