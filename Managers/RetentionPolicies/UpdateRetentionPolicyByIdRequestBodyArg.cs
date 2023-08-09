using System.IO;
using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System;
using System.Text.Json.Serialization;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class UpdateRetentionPolicyByIdRequestBodyArg {
        [JsonPropertyName("policy_name")]
        public string PolicyName { get; }

        [JsonPropertyName("description")]
        public string Description { get; }

        [JsonPropertyName("disposition_action")]
        public UpdateRetentionPolicyByIdRequestBodyArgDispositionActionField DispositionAction { get; }

        [JsonPropertyName("retention_type")]
        public string RetentionType { get; }

        [JsonPropertyName("retention_length")]
        public string RetentionLength { get; }

        [JsonPropertyName("status")]
        public string Status { get; }

        [JsonPropertyName("can_owner_extend_retention")]
        public bool? CanOwnerExtendRetention { get; }

        [JsonPropertyName("are_owners_notified")]
        public bool? AreOwnersNotified { get; }

        [JsonPropertyName("custom_notification_recipients")]
        public IReadOnlyList<UserMini> CustomNotificationRecipients { get; }

        public UpdateRetentionPolicyByIdRequestBodyArg(string policyName, string description, UpdateRetentionPolicyByIdRequestBodyArgDispositionActionField dispositionAction, string retentionType, string retentionLength, string status, bool? canOwnerExtendRetention, bool? areOwnersNotified, IReadOnlyList<UserMini> customNotificationRecipients) {
            PolicyName = policyName;
            Description = description;
            DispositionAction = dispositionAction;
            RetentionType = retentionType;
            RetentionLength = retentionLength;
            Status = status;
            CanOwnerExtendRetention = canOwnerExtendRetention;
            AreOwnersNotified = areOwnersNotified;
            CustomNotificationRecipients = customNotificationRecipients;
        }
    }
}