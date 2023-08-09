using System.IO;
using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;

namespace Box.Schemas {
    public class Users {
        [JsonPropertyName("total_count")]
        public int? TotalCount { get; }

        [JsonPropertyName("limit")]
        public int? Limit { get; }

        [JsonPropertyName("offset")]
        public int? Offset { get; }

        [JsonPropertyName("order")]
        public IReadOnlyList<UsersOrderField> Order { get; }

        [JsonPropertyName("entries")]
        public IReadOnlyList<User> Entries { get; }

        public Users(int? totalCount, int? limit, int? offset, IReadOnlyList<UsersOrderField> order, IReadOnlyList<User> entries) {
            TotalCount = totalCount;
            Limit = limit;
            Offset = offset;
            Order = order;
            Entries = entries;
        }
    }
}