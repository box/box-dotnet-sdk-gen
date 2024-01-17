using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using Box.Sdk.Gen.Schemas;
using Box.Sdk.Gen;

namespace Box.Sdk.Gen.Managers {
    public class RestoreFileFromTrashRequestBody {
        /// <summary>
        /// An optional new name for the file.
        /// </summary>
        [JsonPropertyName("name")]
        public string? Name { get; set; } = default;

        [JsonPropertyName("parent")]
        public RestoreFileFromTrashRequestBodyParentField? Parent { get; set; } = default;

        public RestoreFileFromTrashRequestBody() {
            
        }
    }
}