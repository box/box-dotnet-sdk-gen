using Unions;
using System.Text.Json.Serialization;
using Box.Sdk.Gen.Schemas;

namespace Box.Sdk.Gen.Schemas {
    public class Group : GroupMini {
        /// <summary>
        /// When the group object was created
        /// </summary>
        [JsonPropertyName("created_at")]
        public System.DateTimeOffset? CreatedAt { get; init; }

        /// <summary>
        /// When the group object was last modified
        /// </summary>
        [JsonPropertyName("modified_at")]
        public System.DateTimeOffset? ModifiedAt { get; init; }

        public Group(string id, GroupBaseTypeField type = GroupBaseTypeField.Group) : base(id, type) {
            
        }
        
        [JsonConstructorAttribute]
        internal Group(string id, StringEnum<GroupBaseTypeField> type) : base(id, type ?? new StringEnum<GroupBaseTypeField>(GroupBaseTypeField.Group)) {
            
        }
    }
}