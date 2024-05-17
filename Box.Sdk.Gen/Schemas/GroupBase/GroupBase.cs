using Unions;
using System.Text.Json.Serialization;

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
        public GroupBaseTypeField Type { get; }

        public GroupBase(string id, GroupBaseTypeField type = GroupBaseTypeField.Group) {
            Id = id;
            Type = type;
        }
    }
}