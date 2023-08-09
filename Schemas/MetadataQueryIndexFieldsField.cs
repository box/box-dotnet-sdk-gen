using System.IO;
using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;

namespace Box.Schemas {
    public class MetadataQueryIndexFieldsField {
        [JsonPropertyName("key")]
        public string Key { get; }

        [JsonPropertyName("sort_direction")]
        public MetadataQueryIndexFieldsFieldSortDirectionField SortDirection { get; }

        public MetadataQueryIndexFieldsField(string key, MetadataQueryIndexFieldsFieldSortDirectionField sortDirection) {
            Key = key;
            SortDirection = sortDirection;
        }
    }
}