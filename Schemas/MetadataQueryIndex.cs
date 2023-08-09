using System.IO;
using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;

namespace Box.Schemas {
    public class MetadataQueryIndex {
        [JsonPropertyName("id")]
        public string Id { get; }

        [JsonPropertyName("type")]
        public string Type { get; }

        [JsonPropertyName("status")]
        public MetadataQueryIndexStatusField Status { get; }

        [JsonPropertyName("fields")]
        public IReadOnlyList<MetadataQueryIndexFieldsField> Fields { get; }

        public MetadataQueryIndex(string id, string type, MetadataQueryIndexStatusField status, IReadOnlyList<MetadataQueryIndexFieldsField> fields) {
            Id = id;
            Type = type;
            Status = status;
            Fields = fields;
        }
    }
}