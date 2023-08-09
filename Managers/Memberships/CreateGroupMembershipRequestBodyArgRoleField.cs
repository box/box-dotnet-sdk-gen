using System.ComponentModel;
using Serializer;
using System.Text.Json.Serialization;
using Box.Schemas;
using Box;

namespace Box.Managers {
    [JsonConverter(typeof(StringEnumConverter<CreateGroupMembershipRequestBodyArgRoleField>))]
    public enum CreateGroupMembershipRequestBodyArgRoleField {
        [Description("member")]
        Member,
        [Description("admin")]
        Admin
    }
}