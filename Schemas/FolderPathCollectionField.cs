using System.IO;
using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Text.Json;

namespace Box.Schemas {
    public class FolderPathCollectionField {
        [JsonPropertyName("total_count")]
        public int TotalCount { get; }

        [JsonPropertyName("entries")]
        public IReadOnlyList<FolderMini> Entries { get; }

        public FolderPathCollectionField(int totalCount, IReadOnlyList<FolderMini> entries) {
            TotalCount = totalCount;
            Entries = entries;
        }
    }
}