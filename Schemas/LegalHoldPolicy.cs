using System.IO;
using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;

namespace Box.Schemas {
    public class LegalHoldPolicy : LegalHoldPolicyMini {
        /// <summary>
        /// Name of the legal hold policy.
        /// </summary>
        [JsonPropertyName("policy_name")]
        public string? PolicyName { get; set; } = default;

        /// <summary>
        /// Description of the legal hold policy. Optional
        /// property with a 500 character limit.
        /// </summary>
        [JsonPropertyName("description")]
        public string? Description { get; set; } = default;

        /// <summary>
        /// * 'active' - the policy is not in a transition state
        /// * 'applying' - that the policy is in the process of
        ///   being applied
        /// * 'releasing' - that the process is in the process
        ///   of being released
        /// * 'released' - the policy is no longer active
        /// </summary>
        [JsonPropertyName("status")]
        public LegalHoldPolicyStatusField? Status { get; set; } = default;

        /// <summary>
        /// Counts of assignments within this a legal hold policy by item type
        /// </summary>
        [JsonPropertyName("assignment_counts")]
        public LegalHoldPolicyAssignmentCountsField? AssignmentCounts { get; set; } = default;

        [JsonPropertyName("created_by")]
        public UserMini? CreatedBy { get; set; } = default;

        /// <summary>
        /// When the legal hold policy object was created
        /// </summary>
        [JsonPropertyName("created_at")]
        public string? CreatedAt { get; set; } = default;

        /// <summary>
        /// When the legal hold policy object was modified.
        /// Does not update when assignments are added or removed.
        /// </summary>
        [JsonPropertyName("modified_at")]
        public string? ModifiedAt { get; set; } = default;

        /// <summary>
        /// When the policy release request was sent. (Because
        /// it can take time for a policy to fully delete, this
        /// isn't quite the same time that the policy is fully deleted).
        /// 
        /// If `null`, the policy was not deleted.
        /// </summary>
        [JsonPropertyName("deleted_at")]
        public string? DeletedAt { get; set; } = default;

        /// <summary>
        /// User-specified, optional date filter applies to
        /// Custodian assignments only
        /// </summary>
        [JsonPropertyName("filter_started_at")]
        public string? FilterStartedAt { get; set; } = default;

        /// <summary>
        /// User-specified, optional date filter applies to
        /// Custodian assignments only
        /// </summary>
        [JsonPropertyName("filter_ended_at")]
        public string? FilterEndedAt { get; set; } = default;

        /// <summary>
        /// Optional notes about why the policy was created.
        /// </summary>
        [JsonPropertyName("release_notes")]
        public string? ReleaseNotes { get; set; } = default;

        public LegalHoldPolicy() {
            
        }
    }
}