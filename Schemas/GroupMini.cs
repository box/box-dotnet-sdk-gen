using System.IO;
using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;

namespace Box.Schemas {
    public class GroupMini : GroupBase {
        [JsonPropertyName("name")]
        public string Name { get; }

        [JsonPropertyName("group_type")]
        public GroupMiniGroupTypeField GroupType { get; }

        public GroupMini(string id, GroupBaseTypeField type, string name, GroupMiniGroupTypeField groupType) : base(id, type) {
            Name = name;
            GroupType = groupType;
        }
    }
}