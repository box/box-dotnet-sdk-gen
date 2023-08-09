using System.IO;
using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text.Json.Serialization;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class CreateGroupMembershipRequestBodyArg {
        [JsonPropertyName("user")]
        public CreateGroupMembershipRequestBodyArgUserField User { get; }

        [JsonPropertyName("group")]
        public CreateGroupMembershipRequestBodyArgGroupField Group { get; }

        [JsonPropertyName("role")]
        public CreateGroupMembershipRequestBodyArgRoleField Role { get; }

        [JsonPropertyName("configurable_permissions")]
        public Dictionary<string, bool> ConfigurablePermissions { get; }

        public CreateGroupMembershipRequestBodyArg(CreateGroupMembershipRequestBodyArgUserField user, CreateGroupMembershipRequestBodyArgGroupField group, CreateGroupMembershipRequestBodyArgRoleField role, Dictionary<string, bool> configurablePermissions) {
            User = user;
            Group = group;
            Role = role;
            ConfigurablePermissions = configurablePermissions;
        }
    }
}