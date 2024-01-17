using System.ComponentModel;
using Serializer;
using System.Text.Json.Serialization;
using Box.Sdk.Gen.Schemas;
using Box.Sdk.Gen;

namespace Box.Sdk.Gen.Managers {
    [JsonConverter(typeof(StringEnumConverter<UpdateGroupByIdRequestBodyMemberViewabilityLevelField>))]
    public enum UpdateGroupByIdRequestBodyMemberViewabilityLevelField {
        [Description("admins_only")]
        AdminsOnly,
        [Description("admins_and_members")]
        AdminsAndMembers,
        [Description("all_managed_users")]
        AllManagedUsers
    }
}