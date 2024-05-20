using Unions;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Box.Sdk.Gen.Schemas;
using Box.Sdk.Gen;

namespace Box.Sdk.Gen.Managers {
    public class UpdateFolderByIdRequestBodyParentField {
        /// <summary>
        /// The ID of the new parent folder
        /// </summary>
        [JsonPropertyName("id")]
        public string? Id { get; init; }

        public UpdateFolderByIdRequestBodyParentField() {
            
        }
    }
}