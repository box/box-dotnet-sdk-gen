using Box.Sdk.Gen;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Box.Sdk.Gen.Internal;
using Box.Sdk.Gen.Schemas;

namespace Box.Sdk.Gen.Managers {
    public class UpdateFolderByIdRequestBodyCollectionsField {
        /// <summary>
        /// The unique identifier for this object
        /// </summary>
        [JsonPropertyName("id")]
        public string? Id { get; init; }

        /// <summary>
        /// The type for this object
        /// </summary>
        [JsonPropertyName("type")]
        public string? Type { get; init; }

        public UpdateFolderByIdRequestBodyCollectionsField() {
            
        }
    }
}