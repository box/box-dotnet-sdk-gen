using System.IO;
using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System;
using System.Text.Json.Serialization;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class CreateRetentionPolicyRequestBodyArg {
        [JsonPropertyName("policy_name")]
        public string PolicyName { get; }

        [JsonPropertyName("description")]
        public string Description { get; }

        [JsonPropertyName("policy_type")]
        public CreateRetentionPolicyRequestBodyArgPolicyTypeField PolicyType { get; }

        [JsonPropertyName("disposition_action")]
        public CreateRetentionPolicyRequestBodyArgDispositionActionField DispositionAction { get; }

        [JsonPropertyName("retention_length")]
        public string RetentionLength { get; }

        [JsonPropertyName("retention_type")]
        public CreateRetentionPolicyRequestBodyArgRetentionTypeField RetentionType { get; }

        [JsonPropertyName("can_owner_extend_retention")]
        public bool? CanOwnerExtendRetention { get; }

        [JsonPropertyName("are_owners_notified")]
        public bool? AreOwnersNotified { get; }

        [JsonPropertyName("custom_notification_recipients")]
        public IReadOnlyList<UserMini> CustomNotificationRecipients { get; }

        public CreateRetentionPolicyRequestBodyArg(string policyName, string description, CreateRetentionPolicyRequestBodyArgPolicyTypeField policyType, CreateRetentionPolicyRequestBodyArgDispositionActionField dispositionAction, string retentionLength, CreateRetentionPolicyRequestBodyArgRetentionTypeField retentionType, bool? canOwnerExtendRetention, bool? areOwnersNotified, IReadOnlyList<UserMini> customNotificationRecipients) {
            PolicyName = policyName;
            Description = description;
            PolicyType = policyType;
            DispositionAction = dispositionAction;
            RetentionLength = retentionLength;
            RetentionType = retentionType;
            CanOwnerExtendRetention = canOwnerExtendRetention;
            AreOwnersNotified = areOwnersNotified;
            CustomNotificationRecipients = customNotificationRecipients;
        }
    }
}