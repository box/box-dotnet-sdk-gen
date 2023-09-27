using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Text.Json;

namespace Box.Schemas {
    public class Tasks {
        /// <summary>
        /// One greater than the offset of the last entry in the entire collection.
        /// The total number of entries in the collection may be less than
        /// `total_count`.
        /// </summary>
        [JsonPropertyName("total_count")]
        public long? TotalCount { get; set; } = default;

        /// <summary>
        /// A list of tasks
        /// </summary>
        [JsonPropertyName("entries")]
        public IReadOnlyList<Task>? Entries { get; set; } = default;

        public Tasks() {
            
        }
    }
}