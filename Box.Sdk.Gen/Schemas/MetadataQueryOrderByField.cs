using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;

namespace Box.Sdk.Gen.Schemas {
    public class MetadataQueryOrderByField {
        /// <summary>
        /// The metadata template field to order by.
        /// 
        /// The `field_key` represents the `key` value of a field from the
        /// metadata template being searched for.
        /// </summary>
        [JsonPropertyName("field_key")]
        public string? FieldKey { get; set; } = default;

        /// <summary>
        /// The direction to order by, either ascending or descending.
        /// 
        /// The `ordering` direction must be the same for each item in the
        /// array.
        /// </summary>
        [JsonPropertyName("direction")]
        public MetadataQueryOrderByDirectionField? Direction { get; set; } = default;

        public MetadataQueryOrderByField() {
            
        }
    }
}