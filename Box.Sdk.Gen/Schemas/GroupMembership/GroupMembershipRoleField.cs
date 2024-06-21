using System.ComponentModel;
using Box.Sdk.Gen.Schemas;

namespace Box.Sdk.Gen.Schemas {
    public enum GroupMembershipRoleField {
        [Description("member")]
        Member,
        [Description("admin")]
        Admin
    }
}