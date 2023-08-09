using System.ComponentModel;
using Serializer;
using System.Text.Json.Serialization;

namespace Box.Schemas {
    [JsonConverter(typeof(StringEnumConverter<GroupMembershipTypeField>))]
    public enum GroupMembershipTypeField {
        [Description("group_membership")]
        GroupMembership
    }
}