using Box.Sdk.Gen;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text.Json.Serialization;
using Box.Sdk.Gen.Internal;
using System;
using Box.Sdk.Gen.Schemas;

namespace Box.Sdk.Gen.Managers {
    public class CreateGroupMembershipRequestBody {
        /// <summary>
        /// The user to add to the group.
        /// </summary>
        [JsonPropertyName("user")]
        public CreateGroupMembershipRequestBodyUserField User { get; }

        /// <summary>
        /// The group to add the user to.
        /// </summary>
        [JsonPropertyName("group")]
        public CreateGroupMembershipRequestBodyGroupField Group { get; }

        /// <summary>
        /// The role of the user in the group.
        /// </summary>
        [JsonPropertyName("role")]
        [JsonConverter(typeof(StringEnumConverter<CreateGroupMembershipRequestBodyRoleField>))]
        public StringEnum<CreateGroupMembershipRequestBodyRoleField>? Role { get; init; }

        /// <summary>
        /// Custom configuration for the permissions an admin
        /// if a group will receive. This option has no effect
        /// on members with a role of `member`.
        /// 
        /// Setting these permissions overwrites the default
        /// access levels of an admin.
        /// 
        /// Specifying a value of `null` for this object will disable
        /// all configurable permissions. Specifying permissions will set
        /// them accordingly, omitted permissions will be enabled by default.
        /// </summary>
        [JsonPropertyName("configurable_permissions")]
        public Dictionary<string, bool>? ConfigurablePermissions { get; init; }

        public CreateGroupMembershipRequestBody(CreateGroupMembershipRequestBodyUserField user, CreateGroupMembershipRequestBodyGroupField group) {
            User = user;
            Group = group;
        }
    }
}