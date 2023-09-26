using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Text.Json;

namespace Box.Schemas {
    public class MetadataQueryResults {
        /// <summary>
        /// The mini representation of the files and folders that match the search
        /// terms.
        /// 
        /// By default, this endpoint returns only the most basic info about the
        /// items. To get additional fields for each item, including any of the
        /// metadata, use the `fields` attribute in the query.
        /// </summary>
        [JsonPropertyName("entries")]
        public IReadOnlyList<FileOrFolder>? Entries { get; set; } = default;

        /// <summary>
        /// The limit that was used for this search. This will be the same as the
        /// `limit` query parameter unless that value exceeded the maximum value
        /// allowed.
        /// </summary>
        [JsonPropertyName("limit")]
        public long? Limit { get; set; } = default;

        /// <summary>
        /// The marker for the start of the next page of results.
        /// </summary>
        [JsonPropertyName("next_marker")]
        public string? NextMarker { get; set; } = default;

        public MetadataQueryResults() {
            
        }
    }
}