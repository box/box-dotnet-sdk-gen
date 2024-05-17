using Unions;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Box.Sdk.Gen.Schemas;

namespace Box.Sdk.Gen.Schemas {
    public class Tasks {
        /// <summary>
        /// One greater than the offset of the last entry in the entire collection.
        /// The total number of entries in the collection may be less than
        /// `total_count`.
        /// </summary>
        [JsonPropertyName("total_count")]
        public long? TotalCount { get; init; }

        /// <summary>
        /// A list of tasks
        /// </summary>
        [JsonPropertyName("entries")]
        public IReadOnlyList<Task>? Entries { get; init; }

        public Tasks() {
            
        }
    }
}