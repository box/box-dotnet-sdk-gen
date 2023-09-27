using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Text.Json;

namespace Box.Schemas {
    public class LegalHoldPolicyAssignment : LegalHoldPolicyAssignmentBase {
        [JsonPropertyName("legal_hold_policy")]
        public LegalHoldPolicyMini? LegalHoldPolicy { get; set; } = default;

        [JsonPropertyName("assigned_to")]
        public FileOrFolderOrWebLink? AssignedTo { get; set; } = default;

        [JsonPropertyName("assigned_by")]
        public UserMini? AssignedBy { get; set; } = default;

        /// <summary>
        /// When the legal hold policy assignment object was
        /// created
        /// </summary>
        [JsonPropertyName("assigned_at")]
        public string? AssignedAt { get; set; } = default;

        /// <summary>
        /// When the assignment release request was sent.
        /// (Because it can take time for an assignment to fully
        /// delete, this isn't quite the same time that the
        /// assignment is fully deleted). If null, Assignment
        /// was not deleted.
        /// </summary>
        [JsonPropertyName("deleted_at")]
        public string? DeletedAt { get; set; } = default;

        public LegalHoldPolicyAssignment() {
            
        }
    }
}