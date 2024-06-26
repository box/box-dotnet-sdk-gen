using Unions;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using Box.Sdk.Gen;
using System.Text.Json.Serialization;
using Serializer;
using Box.Sdk.Gen.Schemas;

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