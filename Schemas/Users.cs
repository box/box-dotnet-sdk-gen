using System.IO;
using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;

namespace Box.Schemas {
    public class Users {
        [JsonPropertyName("total_count")]
        public long? TotalCount { get; }

        [JsonPropertyName("limit")]
        public long? Limit { get; }

        [JsonPropertyName("offset")]
        public long? Offset { get; }

        [JsonPropertyName("order")]
        public IReadOnlyList<UsersOrderField> Order { get; }

        [JsonPropertyName("entries")]
        public IReadOnlyList<User> Entries { get; }

        public Users(long? totalCount, long? limit, long? offset, IReadOnlyList<UsersOrderField> order, IReadOnlyList<User> entries) {
            TotalCount = totalCount;
            Limit = limit;
            Offset = offset;
            Order = order;
            Entries = entries;
        }
    }
}