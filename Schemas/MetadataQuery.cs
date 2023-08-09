using System.IO;
using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;

namespace Box.Schemas {
    public class MetadataQuery {
        [JsonPropertyName("from")]
        public string From { get; }

        [JsonPropertyName("query")]
        public string Query { get; }

        [JsonPropertyName("query_params")]
        public Dictionary<string, string> QueryParams { get; }

        [JsonPropertyName("ancestor_folder_id")]
        public string AncestorFolderId { get; }

        [JsonPropertyName("order_by")]
        public IReadOnlyList<MetadataQueryOrderByField> OrderBy { get; }

        [JsonPropertyName("limit")]
        public int? Limit { get; }

        [JsonPropertyName("marker")]
        public string Marker { get; }

        [JsonPropertyName("fields")]
        public IReadOnlyList<string> Fields { get; }

        public MetadataQuery(string from, string query, Dictionary<string, string> queryParams, string ancestorFolderId, IReadOnlyList<MetadataQueryOrderByField> orderBy, int? limit, string marker, IReadOnlyList<string> fields) {
            From = from;
            Query = query;
            QueryParams = queryParams;
            AncestorFolderId = ancestorFolderId;
            OrderBy = orderBy;
            Limit = limit;
            Marker = marker;
            Fields = fields;
        }
    }
}