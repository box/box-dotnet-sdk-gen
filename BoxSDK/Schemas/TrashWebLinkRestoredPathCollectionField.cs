using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Text.Json;

namespace Box.Schemas {
    public class TrashWebLinkRestoredPathCollectionField {
        /// <summary>
        /// The number of folders in this list.
        /// </summary>
        [JsonPropertyName("total_count")]
        public long TotalCount { get; set; }

        /// <summary>
        /// The parent folders for this item
        /// </summary>
        [JsonPropertyName("entries")]
        public IReadOnlyList<FolderMini> Entries { get; set; }

        public TrashWebLinkRestoredPathCollectionField(long totalCount, IReadOnlyList<FolderMini> entries) {
            TotalCount = totalCount;
            Entries = entries;
        }
    }
}