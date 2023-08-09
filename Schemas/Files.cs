using System.IO;
using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;

namespace Box.Schemas {
    public class Files {
        [JsonPropertyName("total_count")]
        public int? TotalCount { get; }

        [JsonPropertyName("entries")]
        public IReadOnlyList<File> Entries { get; }

        public Files(int? totalCount, IReadOnlyList<File> entries) {
            TotalCount = totalCount;
            Entries = entries;
        }
    }
}