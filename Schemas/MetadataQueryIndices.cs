using System.IO;
using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;

namespace Box.Schemas {
    public class MetadataQueryIndices {
        /// <summary>
        /// A collection of metadata query indices.
        /// </summary>
        [JsonPropertyName("entries")]
        public IReadOnlyList<MetadataQueryIndex>? Entries { get; set; } = default;

        /// <summary>
        /// The limit that was used for this request.
        /// </summary>
        [JsonPropertyName("limit")]
        public long? Limit { get; set; } = default;

        /// <summary>
        /// The marker for the start of the next page of results.
        /// </summary>
        [JsonPropertyName("next_marker")]
        public string? NextMarker { get; set; } = default;

        public MetadataQueryIndices() {
            
        }
    }
}