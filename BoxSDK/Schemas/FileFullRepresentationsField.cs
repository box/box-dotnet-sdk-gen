using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Text.Json;

namespace Box.Schemas {
    public class FileFullRepresentationsField {
        /// <summary>
        /// A list of files
        /// </summary>
        [JsonPropertyName("entries")]
        public IReadOnlyList<FileFullRepresentationsFieldEntriesField>? Entries { get; set; } = default;

        public FileFullRepresentationsField() {
            
        }
    }
}