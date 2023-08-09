using System.IO;
using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;

namespace Box.Schemas {
    public class Invite {
        [JsonPropertyName("id")]
        public string Id { get; }

        [JsonPropertyName("type")]
        public InviteTypeField Type { get; }

        [JsonPropertyName("invited_to")]
        public InviteInvitedToField InvitedTo { get; }

        [JsonPropertyName("actionable_by")]
        public UserMini ActionableBy { get; }

        [JsonPropertyName("invited_by")]
        public UserMini InvitedBy { get; }

        [JsonPropertyName("status")]
        public string Status { get; }

        [JsonPropertyName("created_at")]
        public string CreatedAt { get; }

        [JsonPropertyName("modified_at")]
        public string ModifiedAt { get; }

        public Invite(string id, InviteTypeField type, InviteInvitedToField invitedTo, UserMini actionableBy, UserMini invitedBy, string status, string createdAt, string modifiedAt) {
            Id = id;
            Type = type;
            InvitedTo = invitedTo;
            ActionableBy = actionableBy;
            InvitedBy = invitedBy;
            Status = status;
            CreatedAt = createdAt;
            ModifiedAt = modifiedAt;
        }
    }
}