using System.IO;
using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Text.Json;

namespace Box.Schemas {
    public class Items {
        [JsonPropertyName("total_count")]
        public int? TotalCount { get; }

        [JsonPropertyName("limit")]
        public int? Limit { get; }

        [JsonPropertyName("offset")]
        public int? Offset { get; }

        [JsonPropertyName("order")]
        public IReadOnlyList<ItemsOrderField> Order { get; }

        [JsonPropertyName("entries")]
        public IReadOnlyList<ItemsEntriesField> Entries { get; }

        public Items(int? totalCount, int? limit, int? offset, IReadOnlyList<ItemsOrderField> order, IReadOnlyList<ItemsEntriesField> entries) {
            TotalCount = totalCount;
            Limit = limit;
            Offset = offset;
            Order = order;
            Entries = entries;
        }
    }
}