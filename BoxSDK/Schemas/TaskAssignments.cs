using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;

namespace Box.Schemas {
    public class TaskAssignments {
        /// <summary>
        /// The total number of items in this collection.
        /// </summary>
        [JsonPropertyName("total_count")]
        public long? TotalCount { get; set; } = default;

        /// <summary>
        /// A list of task assignments
        /// </summary>
        [JsonPropertyName("entries")]
        public IReadOnlyList<TaskAssignment>? Entries { get; set; } = default;

        public TaskAssignments() {
            
        }
    }
}