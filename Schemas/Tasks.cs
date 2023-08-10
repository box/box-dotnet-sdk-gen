using System.IO;
using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;

namespace Box.Schemas {
    public class Tasks {
        [JsonPropertyName("total_count")]
        public int? TotalCount { get; }

        [JsonPropertyName("entries")]
        public IReadOnlyList<Task> Entries { get; }

        public Tasks(int? totalCount, IReadOnlyList<Task> entries) {
            TotalCount = totalCount;
            Entries = entries;
        }
    }
}