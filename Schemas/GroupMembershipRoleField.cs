using System.ComponentModel;
using Serializer;
using System.Text.Json.Serialization;

namespace Box.Schemas {
    [JsonConverter(typeof(StringEnumConverter<GroupMembershipRoleField>))]
    public enum GroupMembershipRoleField {
        [Description("member")]
        Member,
        [Description("admin")]
        Admin
    }
}