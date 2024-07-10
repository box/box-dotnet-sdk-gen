using Box.Sdk.Gen;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Box.Sdk.Gen.Internal;
using Box.Sdk.Gen.Schemas;

namespace Box.Sdk.Gen.Managers {
    public class UpdateFileByIdRequestBodyParentField {
        /// <summary>
        /// The ID of parent item
        /// </summary>
        [JsonPropertyName("id")]
        public string? Id { get; init; }

        public UpdateFileByIdRequestBodyParentField() {
            
        }
    }
}