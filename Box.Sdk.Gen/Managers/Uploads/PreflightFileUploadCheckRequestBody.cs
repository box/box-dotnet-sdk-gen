using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using Box.Sdk.Gen.Schemas;
using Box.Sdk.Gen;

namespace Box.Sdk.Gen.Managers {
    public class PreflightFileUploadCheckRequestBody {
        /// <summary>
        /// The name for the file
        /// </summary>
        [JsonPropertyName("name")]
        public string? Name { get; set; } = default;

        /// <summary>
        /// The size of the file in bytes
        /// </summary>
        [JsonPropertyName("size")]
        public int? Size { get; set; } = default;

        [JsonPropertyName("parent")]
        public PreflightFileUploadCheckRequestBodyParentField? Parent { get; set; } = default;

        public PreflightFileUploadCheckRequestBody() {
            
        }
    }
}