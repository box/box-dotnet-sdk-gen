using System.IO;
using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;

namespace Box.Schemas {
    public class GroupBase {
        [JsonPropertyName("id")]
        public string Id { get; }

        [JsonPropertyName("type")]
        public GroupBaseTypeField Type { get; }

        public GroupBase(string id, GroupBaseTypeField type) {
            Id = id;
            Type = type;
        }
    }
}