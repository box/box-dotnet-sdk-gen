using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;

namespace Box.Schemas {
    public class Files {
        /// <summary>
        /// The number of files.
        /// </summary>
        [JsonPropertyName("total_count")]
        public long? TotalCount { get; set; } = default;

        /// <summary>
        /// A list of files
        /// </summary>
        [JsonPropertyName("entries")]
        public IReadOnlyList<File>? Entries { get; set; } = default;

        public Files() {
            
        }
    }
}