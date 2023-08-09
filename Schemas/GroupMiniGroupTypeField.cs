using System.ComponentModel;
using Serializer;
using System.Text.Json.Serialization;

namespace Box.Schemas {
    [JsonConverter(typeof(StringEnumConverter<GroupMiniGroupTypeField>))]
    public enum GroupMiniGroupTypeField {
        [Description("managed_group")]
        ManagedGroup,
        [Description("all_users_group")]
        AllUsersGroup
    }
}