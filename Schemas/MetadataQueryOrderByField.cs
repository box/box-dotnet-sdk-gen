using System.IO;
using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;

namespace Box.Schemas {
    public class MetadataQueryOrderByField {
        [JsonPropertyName("field_key")]
        public string FieldKey { get; }

        [JsonPropertyName("direction")]
        public MetadataQueryOrderByFieldDirectionField Direction { get; }

        public MetadataQueryOrderByField(string fieldKey, MetadataQueryOrderByFieldDirectionField direction) {
            FieldKey = fieldKey;
            Direction = direction;
        }
    }
}