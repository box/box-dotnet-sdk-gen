using System.ComponentModel;
using Serializer;
using System.Text.Json.Serialization;
using Box.Schemas;
using Box;

namespace Box.Managers {
    [JsonConverter(typeof(StringEnumConverter<UpdateGroupByIdRequestBodyArgMemberViewabilityLevelField>))]
    public enum UpdateGroupByIdRequestBodyArgMemberViewabilityLevelField {
        [Description("admins_only")]
        AdminsOnly,
        [Description("admins_and_members")]
        AdminsAndMembers,
        [Description("all_managed_users")]
        AllManagedUsers
    }
}