using System.ComponentModel;
using Serializer;
using System.Text.Json.Serialization;
using Box.Sdk.Gen.Schemas;

namespace Box.Sdk.Gen.Schemas {
    [JsonConverter(typeof(StringEnumConverter<GroupMembershipTypeField>))]
    public enum GroupMembershipTypeField {
        [Description("group_membership")]
        GroupMembership
    }
}