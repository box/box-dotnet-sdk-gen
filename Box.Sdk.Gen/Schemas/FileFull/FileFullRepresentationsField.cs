using Unions;
using System.Text.Json.Serialization;
using Box.Sdk.Gen;
using Serializer;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Text.Json;
using Box.Sdk.Gen.Schemas;

namespace Box.Sdk.Gen.Schemas {
    public class FileFullRepresentationsField {
        /// <summary>
        /// A list of files
        /// </summary>
        [JsonPropertyName("entries")]
        public IReadOnlyList<FileFullRepresentationsEntriesField>? Entries { get; init; }

        public FileFullRepresentationsField() {
            
        }
    }
}