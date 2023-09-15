using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;

namespace Box.Schemas {
    public class MetadataQueryIndexFieldsField {
        /// <summary>
        /// The metadata template field key.
        /// </summary>
        [JsonPropertyName("key")]
        public string? Key { get; set; } = default;

        /// <summary>
        /// The sort direction of the field.
        /// </summary>
        [JsonPropertyName("sort_direction")]
        public MetadataQueryIndexFieldsFieldSortDirectionField? SortDirection { get; set; } = default;

        public MetadataQueryIndexFieldsField() {
            
        }
    }
}