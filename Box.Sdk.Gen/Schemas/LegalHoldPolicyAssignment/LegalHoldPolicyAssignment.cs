using Box.Sdk.Gen;
using System.Text.Json.Serialization;
using Box.Sdk.Gen.Schemas;

namespace Box.Sdk.Gen.Schemas {
    public class LegalHoldPolicyAssignment : LegalHoldPolicyAssignmentBase {
        [JsonPropertyName("legal_hold_policy")]
        public LegalHoldPolicyMini? LegalHoldPolicy { get; init; }

        [JsonPropertyName("assigned_to")]
        public FileOrFolderOrWebLink? AssignedTo { get; init; }

        [JsonPropertyName("assigned_by")]
        public UserMini? AssignedBy { get; init; }

        /// <summary>
        /// When the legal hold policy assignment object was
        /// created
        /// </summary>
        [JsonPropertyName("assigned_at")]
        public System.DateTimeOffset? AssignedAt { get; init; }

        /// <summary>
        /// When the assignment release request was sent.
        /// (Because it can take time for an assignment to fully
        /// delete, this isn't quite the same time that the
        /// assignment is fully deleted). If null, Assignment
        /// was not deleted.
        /// </summary>
        [JsonPropertyName("deleted_at")]
        public System.DateTimeOffset? DeletedAt { get; init; }

        public LegalHoldPolicyAssignment() {
            
        }
    }
}