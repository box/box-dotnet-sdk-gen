using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Text.Json;

namespace Box.Sdk.Gen.Schemas {
    public class GroupMini : GroupBase {
        /// <summary>
        /// The name of the group
        /// </summary>
        [JsonPropertyName("name")]
        public string? Name { get; set; } = default;

        /// <summary>
        /// The type of the group.
        /// </summary>
        [JsonPropertyName("group_type")]
        public GroupMiniGroupTypeField? GroupType { get; set; } = default;

        public GroupMini(string id, GroupBaseTypeField type) : base(id, type) {
            
        }
    }
}