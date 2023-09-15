using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;

namespace Box.Schemas {
    public class StoragePolicyAssignmentAssignedToField {
        /// <summary>
        /// The unique identifier for this object
        /// </summary>
        [JsonPropertyName("id")]
        public string? Id { get; set; } = default;

        /// <summary>
        /// The type for this object
        /// </summary>
        [JsonPropertyName("type")]
        public string? Type { get; set; } = default;

        public StoragePolicyAssignmentAssignedToField() {
            
        }
    }
}