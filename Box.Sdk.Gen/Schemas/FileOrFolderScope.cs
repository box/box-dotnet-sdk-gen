using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Text.Json;

namespace Box.Sdk.Gen.Schemas {
    public class FileOrFolderScope {
        /// <summary>
        /// The scopes for the resource access
        /// </summary>
        [JsonPropertyName("scope")]
        public FileOrFolderScopeScopeField? Scope { get; set; } = default;

        [JsonPropertyName("object")]
        public FolderMiniOrFileMini? Object { get; set; } = default;

        public FileOrFolderScope() {
            
        }
    }
}