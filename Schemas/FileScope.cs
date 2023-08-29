using System.IO;
using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;

namespace Box.Schemas {
    public class FileScope {
        /// <summary>
        /// The file scopes for the file access
        /// </summary>
        [JsonPropertyName("scope")]
        public FileScopeScopeField? Scope { get; set; } = default;

        [JsonPropertyName("object")]
        public FileMini? Object { get; set; } = default;

        public FileScope() {
            
        }
    }
}