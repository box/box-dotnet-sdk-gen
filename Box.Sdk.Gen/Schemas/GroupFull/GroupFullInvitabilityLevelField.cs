using System.ComponentModel;
using Box.Sdk.Gen.Schemas;

namespace Box.Sdk.Gen.Schemas {
    public enum GroupFullInvitabilityLevelField {
        [Description("admins_only")]
        AdminsOnly,
        [Description("admins_and_members")]
        AdminsAndMembers,
        [Description("all_managed_users")]
        AllManagedUsers
    }
}