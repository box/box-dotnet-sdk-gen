using Box.Sdk.Gen;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Box.Sdk.Gen.Schemas;

namespace Box.Sdk.Gen.Schemas {
    public class Files {
        /// <summary>
        /// The number of files.
        /// </summary>
        [JsonPropertyName("total_count")]
        public long? TotalCount { get; init; }

        /// <summary>
        /// A list of files
        /// </summary>
        [JsonPropertyName("entries")]
        public IReadOnlyList<FileFull>? Entries { get; init; }

        public Files() {
            
        }
    }
}