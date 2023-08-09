using System.IO;
using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;

namespace Box.Schemas {
    public class GroupMembership {
        [JsonPropertyName("id")]
        public string Id { get; }

        [JsonPropertyName("type")]
        public GroupMembershipTypeField Type { get; }

        [JsonPropertyName("user")]
        public UserMini User { get; }

        [JsonPropertyName("group")]
        public GroupMini Group { get; }

        [JsonPropertyName("role")]
        public GroupMembershipRoleField Role { get; }

        [JsonPropertyName("created_at")]
        public string CreatedAt { get; }

        [JsonPropertyName("modified_at")]
        public string ModifiedAt { get; }

        public GroupMembership(string id, GroupMembershipTypeField type, UserMini user, GroupMini group, GroupMembershipRoleField role, string createdAt, string modifiedAt) {
            Id = id;
            Type = type;
            User = user;
            Group = group;
            Role = role;
            CreatedAt = createdAt;
            ModifiedAt = modifiedAt;
        }
    }
}