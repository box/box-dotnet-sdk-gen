using System.ComponentModel;
using Serializer;
using System.Text.Json.Serialization;
using Box.Sdk.Gen.Schemas;
using Box.Sdk.Gen;

namespace Box.Sdk.Gen.Managers {
    [JsonConverter(typeof(StringEnumConverter<CreateGroupRequestBodyMemberViewabilityLevelField>))]
    public enum CreateGroupRequestBodyMemberViewabilityLevelField {
        [Description("admins_only")]
        AdminsOnly,
        [Description("admins_and_members")]
        AdminsAndMembers,
        [Description("all_managed_users")]
        AllManagedUsers
    }
}