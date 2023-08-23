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
        public long? TotalCount { get; }

        [JsonPropertyName("limit")]
        public long? Limit { get; }

        [JsonPropertyName("offset")]
        public long? Offset { get; }

        [JsonPropertyName("order")]
        public IReadOnlyList<ItemsOrderField> Order { get; }

        [JsonPropertyName("entries")]
        public IReadOnlyList<ItemsEntriesField> Entries { get; }

        public Items(long? totalCount, long? limit, long? offset, IReadOnlyList<ItemsOrderField> order, IReadOnlyList<ItemsEntriesField> entries) {
            TotalCount = totalCount;
            Limit = limit;
            Offset = offset;
            Order = order;
            Entries = entries;
        }
    }
}