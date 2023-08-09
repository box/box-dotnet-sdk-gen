using System.IO;
using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;

namespace Box.Schemas {
    public class GroupMemberships {
        [JsonPropertyName("total_count")]
        public int? TotalCount { get; }

        [JsonPropertyName("limit")]
        public int? Limit { get; }

        [JsonPropertyName("offset")]
        public int? Offset { get; }

        [JsonPropertyName("order")]
        public IReadOnlyList<GroupMembershipsOrderField> Order { get; }

        [JsonPropertyName("entries")]
        public IReadOnlyList<GroupMembership> Entries { get; }

        public GroupMemberships(int? totalCount, int? limit, int? offset, IReadOnlyList<GroupMembershipsOrderField> order, IReadOnlyList<GroupMembership> entries) {
            TotalCount = totalCount;
            Limit = limit;
            Offset = offset;
            Order = order;
            Entries = entries;
        }
    }
}