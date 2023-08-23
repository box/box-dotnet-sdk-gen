using System.IO;
using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;

namespace Box.Schemas {
    public class GroupMemberships {
        [JsonPropertyName("total_count")]
        public long? TotalCount { get; }

        [JsonPropertyName("limit")]
        public long? Limit { get; }

        [JsonPropertyName("offset")]
        public long? Offset { get; }

        [JsonPropertyName("order")]
        public IReadOnlyList<GroupMembershipsOrderField> Order { get; }

        [JsonPropertyName("entries")]
        public IReadOnlyList<GroupMembership> Entries { get; }

        public GroupMemberships(long? totalCount, long? limit, long? offset, IReadOnlyList<GroupMembershipsOrderField> order, IReadOnlyList<GroupMembership> entries) {
            TotalCount = totalCount;
            Limit = limit;
            Offset = offset;
            Order = order;
            Entries = entries;
        }
    }
}