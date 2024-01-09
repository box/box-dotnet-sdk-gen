using System.ComponentModel;
using Serializer;
using System.Text.Json.Serialization;
using Box.Schemas;
using Box;

namespace Box.Managers {
    [JsonConverter(typeof(StringEnumConverter<UpdateGroupMembershipByIdRequestBodyRoleField>))]
    public enum UpdateGroupMembershipByIdRequestBodyRoleField {
        [Description("member")]
        Member,
        [Description("admin")]
        Admin
    }
}