using System.IO;
using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;

namespace Box.Schemas {
    public class Groups {
        [JsonPropertyName("total_count")]
        public int? TotalCount { get; }

        [JsonPropertyName("limit")]
        public int? Limit { get; }

        [JsonPropertyName("offset")]
        public int? Offset { get; }

        [JsonPropertyName("order")]
        public IReadOnlyList<GroupsOrderField> Order { get; }

        [JsonPropertyName("entries")]
        public IReadOnlyList<GroupMini> Entries { get; }

        public Groups(int? totalCount, int? limit, int? offset, IReadOnlyList<GroupsOrderField> order, IReadOnlyList<GroupMini> entries) {
            TotalCount = totalCount;
            Limit = limit;
            Offset = offset;
            Order = order;
            Entries = entries;
        }
    }
}