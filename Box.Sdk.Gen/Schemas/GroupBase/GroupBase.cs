using Box.Sdk.Gen;
using System.Text.Json.Serialization;
using Box.Sdk.Gen.Internal;

namespace Box.Sdk.Gen.Schemas {
    public class GroupBase {
        /// <summary>
        /// The unique identifier for this object
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; }

        /// <summary>
        /// `group`
        /// </summary>
        [JsonPropertyName("type")]
        [JsonConverter(typeof(StringEnumConverter<GroupBaseTypeField>))]
        public StringEnum<GroupBaseTypeField> Type { get; }

        public GroupBase(string id, GroupBaseTypeField type = GroupBaseTypeField.Group) {
            Id = id;
            Type = type;
        }
        
        [JsonConstructorAttribute]
        internal GroupBase(string id, StringEnum<GroupBaseTypeField> type) {
            Id = id;
            Type = GroupBaseTypeField.Group;
        }
    }
}