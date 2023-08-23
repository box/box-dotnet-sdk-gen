using System.IO;
using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;

namespace Box.Schemas {
    public class TrashFolderPathCollectionField {
        [JsonPropertyName("total_count")]
        public long TotalCount { get; }

        [JsonPropertyName("entries")]
        public IReadOnlyList<TrashFolderPathCollectionFieldEntriesField> Entries { get; }

        public TrashFolderPathCollectionField(long totalCount, IReadOnlyList<TrashFolderPathCollectionFieldEntriesField> entries) {
            TotalCount = totalCount;
            Entries = entries;
        }
    }
}