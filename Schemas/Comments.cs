using System.IO;
using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;

namespace Box.Schemas {
    public class Comments {
        [JsonPropertyName("total_count")]
        public long? TotalCount { get; }

        [JsonPropertyName("limit")]
        public long? Limit { get; }

        [JsonPropertyName("offset")]
        public long? Offset { get; }

        [JsonPropertyName("order")]
        public IReadOnlyList<CommentsOrderField> Order { get; }

        [JsonPropertyName("entries")]
        public IReadOnlyList<Comment> Entries { get; }

        public Comments(long? totalCount, long? limit, long? offset, IReadOnlyList<CommentsOrderField> order, IReadOnlyList<Comment> entries) {
            TotalCount = totalCount;
            Limit = limit;
            Offset = offset;
            Order = order;
            Entries = entries;
        }
    }
}