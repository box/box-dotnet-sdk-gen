using System.IO;
using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;

namespace Box.Schemas {
    public class Group : GroupMini {
        [JsonPropertyName("created_at")]
        public string CreatedAt { get; }

        [JsonPropertyName("modified_at")]
        public string ModifiedAt { get; }

        public Group(string id, GroupBaseTypeField type, string name, GroupMiniGroupTypeField groupType, string createdAt, string modifiedAt) : base(id, type, name, groupType) {
            CreatedAt = createdAt;
            ModifiedAt = modifiedAt;
        }
    }
}