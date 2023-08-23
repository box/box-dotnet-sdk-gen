using System.IO;
using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;

namespace Box.Schemas {
    public class FileVersions {
        [JsonPropertyName("total_count")]
        public long? TotalCount { get; }

        [JsonPropertyName("limit")]
        public long? Limit { get; }

        [JsonPropertyName("offset")]
        public long? Offset { get; }

        [JsonPropertyName("order")]
        public IReadOnlyList<FileVersionsOrderField> Order { get; }

        [JsonPropertyName("entries")]
        public IReadOnlyList<FileVersion> Entries { get; }

        public FileVersions(long? totalCount, long? limit, long? offset, IReadOnlyList<FileVersionsOrderField> order, IReadOnlyList<FileVersion> entries) {
            TotalCount = totalCount;
            Limit = limit;
            Offset = offset;
            Order = order;
            Entries = entries;
        }
    }
}