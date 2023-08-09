using System.IO;
using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;

namespace Box.Schemas {
    public class GroupMembershipsOrderField {
        [JsonPropertyName("by")]
        public string By { get; }

        [JsonPropertyName("direction")]
        public GroupMembershipsOrderFieldDirectionField Direction { get; }

        public GroupMembershipsOrderField(string by, GroupMembershipsOrderFieldDirectionField direction) {
            By = by;
            Direction = direction;
        }
    }
}