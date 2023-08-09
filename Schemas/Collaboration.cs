using System.IO;
using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Text.Json;

namespace Box.Schemas {
    public class Collaboration {
        [JsonPropertyName("id")]
        public string Id { get; }

        [JsonPropertyName("type")]
        public CollaborationTypeField Type { get; }

        [JsonPropertyName("item")]
        public CollaborationItemField Item { get; }

        [JsonPropertyName("accessible_by")]
        public UserCollaborations AccessibleBy { get; }

        [JsonPropertyName("invite_email")]
        public string InviteEmail { get; }

        [JsonPropertyName("role")]
        public CollaborationRoleField Role { get; }

        [JsonPropertyName("expires_at")]
        public string ExpiresAt { get; }

        [JsonPropertyName("status")]
        public CollaborationStatusField Status { get; }

        [JsonPropertyName("acknowledged_at")]
        public string AcknowledgedAt { get; }

        [JsonPropertyName("created_by")]
        public UserCollaborations CreatedBy { get; }

        [JsonPropertyName("created_at")]
        public string CreatedAt { get; }

        [JsonPropertyName("modified_at")]
        public string ModifiedAt { get; }

        [JsonPropertyName("acceptance_requirements_status")]
        public CollaborationAcceptanceRequirementsStatusField AcceptanceRequirementsStatus { get; }

        public Collaboration(string id, CollaborationTypeField type, CollaborationItemField item, UserCollaborations accessibleBy, string inviteEmail, CollaborationRoleField role, string expiresAt, CollaborationStatusField status, string acknowledgedAt, UserCollaborations createdBy, string createdAt, string modifiedAt, CollaborationAcceptanceRequirementsStatusField acceptanceRequirementsStatus) {
            Id = id;
            Type = type;
            Item = item;
            AccessibleBy = accessibleBy;
            InviteEmail = inviteEmail;
            Role = role;
            ExpiresAt = expiresAt;
            Status = status;
            AcknowledgedAt = acknowledgedAt;
            CreatedBy = createdBy;
            CreatedAt = createdAt;
            ModifiedAt = modifiedAt;
            AcceptanceRequirementsStatus = acceptanceRequirementsStatus;
        }
    }
}