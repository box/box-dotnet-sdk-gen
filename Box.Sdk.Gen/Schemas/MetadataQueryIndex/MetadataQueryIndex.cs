using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;

namespace Box.Sdk.Gen.Schemas {
    public class MetadataQueryIndex {
        /// <summary>
        /// The ID of the metadata query index.
        /// </summary>
        [JsonPropertyName("id")]
        public string? Id { get; init; }

        /// <summary>
        /// Value is always `metadata_query_index`
        /// </summary>
        [JsonPropertyName("type")]
        public string Type { get; }

        /// <summary>
        /// The status of the metadata query index
        /// </summary>
        [JsonPropertyName("status")]
        public MetadataQueryIndexStatusField Status { get; }

        /// <summary>
        /// A list of template fields which make up the index.
        /// </summary>
        [JsonPropertyName("fields")]
        public IReadOnlyList<MetadataQueryIndexFieldsField>? Fields { get; init; }

        public MetadataQueryIndex(string type, MetadataQueryIndexStatusField status) {
            Type = type;
            Status = status;
        }
    }
}