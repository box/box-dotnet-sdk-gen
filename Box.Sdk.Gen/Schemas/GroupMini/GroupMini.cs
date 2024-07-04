using Box.Sdk.Gen;
using System.Text.Json.Serialization;
using Box.Sdk.Gen.Internal;
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
        [JsonConverter(typeof(StringEnumConverter<GroupMiniGroupTypeField>))]
        public StringEnum<GroupMiniGroupTypeField>? GroupType { get; init; }

        public GroupMini(string id, GroupBaseTypeField type = GroupBaseTypeField.Group) : base(id, type) {
            
        }
        
        [JsonConstructorAttribute]
        internal GroupMini(string id, StringEnum<GroupBaseTypeField> type) : base(id, type ?? new StringEnum<GroupBaseTypeField>(GroupBaseTypeField.Group)) {
            
        }
    }
}