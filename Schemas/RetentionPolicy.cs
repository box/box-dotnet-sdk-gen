using System.IO;
using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;

namespace Box.Schemas {
    public class RetentionPolicy : RetentionPolicyMini {
        [JsonPropertyName("description")]
        public string Description { get; }

        [JsonPropertyName("policy_type")]
        public RetentionPolicyPolicyTypeField PolicyType { get; }

        [JsonPropertyName("retention_type")]
        public RetentionPolicyRetentionTypeField RetentionType { get; }

        [JsonPropertyName("status")]
        public RetentionPolicyStatusField Status { get; }

        [JsonPropertyName("created_by")]
        public UserMini CreatedBy { get; }

        [JsonPropertyName("created_at")]
        public string CreatedAt { get; }

        [JsonPropertyName("modified_at")]
        public string ModifiedAt { get; }

        [JsonPropertyName("can_owner_extend_retention")]
        public bool? CanOwnerExtendRetention { get; }

        [JsonPropertyName("are_owners_notified")]
        public bool? AreOwnersNotified { get; }

        [JsonPropertyName("custom_notification_recipients")]
        public IReadOnlyList<UserMini> CustomNotificationRecipients { get; }

        [JsonPropertyName("assignment_counts")]
        public RetentionPolicyAssignmentCountsField AssignmentCounts { get; }

        public RetentionPolicy(string id, RetentionPolicyBaseTypeField type, string policyName, string retentionLength, RetentionPolicyMiniDispositionActionField dispositionAction, string description, RetentionPolicyPolicyTypeField policyType, RetentionPolicyRetentionTypeField retentionType, RetentionPolicyStatusField status, UserMini createdBy, string createdAt, string modifiedAt, bool? canOwnerExtendRetention, bool? areOwnersNotified, IReadOnlyList<UserMini> customNotificationRecipients, RetentionPolicyAssignmentCountsField assignmentCounts) : base(id, type, policyName, retentionLength, dispositionAction) {
            Description = description;
            PolicyType = policyType;
            RetentionType = retentionType;
            Status = status;
            CreatedBy = createdBy;
            CreatedAt = createdAt;
            ModifiedAt = modifiedAt;
            CanOwnerExtendRetention = canOwnerExtendRetention;
            AreOwnersNotified = areOwnersNotified;
            CustomNotificationRecipients = customNotificationRecipients;
            AssignmentCounts = assignmentCounts;
        }
    }
}