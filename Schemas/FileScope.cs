using System.IO;
using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;

namespace Box.Schemas {
    public class FileScope {
        [JsonPropertyName("scope")]
        public FileScopeScopeField Scope { get; }

        [JsonPropertyName("object")]
        public FileMini Object { get; }

        public FileScope(FileScopeScopeField scope, FileMini objectParam) {
            Scope = scope;
            Object = objectParam;
        }
    }
}