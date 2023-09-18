using System.ComponentModel;
using Serializer;
using System.Text.Json.Serialization;
using Box.Schemas;
using Box;

namespace Box.Managers {
    [JsonConverter(typeof(StringEnumConverter<UpdateGroupMembershipByIdRequestBodyArgRoleField>))]
    public enum UpdateGroupMembershipByIdRequestBodyArgRoleField {
        [Description("member")]
        Member,
        [Description("admin")]
        Admin
    }
}