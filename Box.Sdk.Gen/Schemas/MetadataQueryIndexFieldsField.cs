using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Text.Json;

namespace Box.Sdk.Gen.Schemas {
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
        public MetadataQueryIndexFieldsSortDirectionField? SortDirection { get; set; } = default;

        public MetadataQueryIndexFieldsField() {
            
        }
    }
}