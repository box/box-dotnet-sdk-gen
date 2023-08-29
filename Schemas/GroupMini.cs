using System.IO;
using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;

namespace Box.Schemas {
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

        public GroupMini() {
            
        }
    }
}