using Unions;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class UpdateFolderByIdRequestBodyArgCollectionsField {
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

        public UpdateFolderByIdRequestBodyArgCollectionsField() {
            
        }
    }
}