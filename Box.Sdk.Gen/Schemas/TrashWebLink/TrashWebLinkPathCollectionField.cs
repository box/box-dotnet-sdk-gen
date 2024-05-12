using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using Box.Sdk.Gen.Schemas;

namespace Box.Sdk.Gen.Schemas {
    public class TrashWebLinkPathCollectionField {
        /// <summary>
        /// The number of folders in this list.
        /// </summary>
        [JsonPropertyName("total_count")]
        public long TotalCount { get; set; }

        /// <summary>
        /// Array of folders for this item's path collection
        /// </summary>
        [JsonPropertyName("entries")]
        public IReadOnlyList<TrashWebLinkPathCollectionEntriesField> Entries { get; set; }

        public TrashWebLinkPathCollectionField(long totalCount, IReadOnlyList<TrashWebLinkPathCollectionEntriesField> entries) {
            TotalCount = totalCount;
            Entries = entries;
        }
    }
}