using Box.Sdk.Gen;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Box.Sdk.Gen.Schemas;

namespace Box.Sdk.Gen.Schemas {
    public class Metadatas {
        /// <summary>
        /// A list of metadata instances, as applied to this file or folder.
        /// </summary>
        [JsonPropertyName("entries")]
        public IReadOnlyList<Metadata>? Entries { get; init; }

        /// <summary>
        /// The limit that was used for this page of results.
        /// </summary>
        [JsonPropertyName("limit")]
        public long? Limit { get; init; }

        public Metadatas() {
            
        }
    }
}