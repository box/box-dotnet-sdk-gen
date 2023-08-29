using System.IO;
using Unions;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class PreflightFileUploadRequestBodyArg {
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
        public PreflightFileUploadRequestBodyArgParentField? Parent { get; set; } = default;

        public PreflightFileUploadRequestBodyArg() {
            
        }
    }
}