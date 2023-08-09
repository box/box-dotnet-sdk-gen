using System.IO;
using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;

namespace Box.Schemas {
    public class GroupsOrderField {
        [JsonPropertyName("by")]
        public string By { get; }

        [JsonPropertyName("direction")]
        public GroupsOrderFieldDirectionField Direction { get; }

        public GroupsOrderField(string by, GroupsOrderFieldDirectionField direction) {
            By = by;
            Direction = direction;
        }
    }
}