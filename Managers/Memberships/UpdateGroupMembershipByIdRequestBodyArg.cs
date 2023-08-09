using System.IO;
using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text.Json.Serialization;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class UpdateGroupMembershipByIdRequestBodyArg {
        [JsonPropertyName("role")]
        public UpdateGroupMembershipByIdRequestBodyArgRoleField Role { get; }

        [JsonPropertyName("configurable_permissions")]
        public Dictionary<string, bool> ConfigurablePermissions { get; }

        public UpdateGroupMembershipByIdRequestBodyArg(UpdateGroupMembershipByIdRequestBodyArgRoleField role, Dictionary<string, bool> configurablePermissions) {
            Role = role;
            ConfigurablePermissions = configurablePermissions;
        }
    }
}