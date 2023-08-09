using System.IO;
using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;

namespace Box.Schemas {
    public class TaskAssignments {
        [JsonPropertyName("total_count")]
        public int? TotalCount { get; }

        [JsonPropertyName("entries")]
        public IReadOnlyList<TaskAssignment> Entries { get; }

        public TaskAssignments(int? totalCount, IReadOnlyList<TaskAssignment> entries) {
            TotalCount = totalCount;
            Entries = entries;
        }
    }
}