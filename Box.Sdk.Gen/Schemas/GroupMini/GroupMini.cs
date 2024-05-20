using Unions;
using System.Text.Json.Serialization;
using Box.Sdk.Gen.Schemas;

namespace Box.Sdk.Gen.Schemas {
    public class GroupMini : GroupBase {
        /// <summary>
        /// The name of the group
        /// </summary>
        [JsonPropertyName("name")]
        public string? Name { get; init; }

        /// <summary>
        /// The type of the group.
        /// </summary>
        [JsonPropertyName("group_type")]
        public GroupMiniGroupTypeField? GroupType { get; init; }

        public GroupMini(string id, GroupBaseTypeField type = GroupBaseTypeField.Group) : base(id, type) {
            
        }
    }
}