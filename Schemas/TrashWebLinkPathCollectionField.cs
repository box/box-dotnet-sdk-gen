using System.IO;
using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;

namespace Box.Schemas {
    public class TrashWebLinkPathCollectionField {
        [JsonPropertyName("total_count")]
        public int TotalCount { get; }

        [JsonPropertyName("entries")]
        public IReadOnlyList<TrashWebLinkPathCollectionFieldEntriesField> Entries { get; }

        public TrashWebLinkPathCollectionField(int totalCount, IReadOnlyList<TrashWebLinkPathCollectionFieldEntriesField> entries) {
            TotalCount = totalCount;
            Entries = entries;
        }
    }
}