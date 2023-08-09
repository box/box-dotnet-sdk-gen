using System.IO;
using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;

namespace Box.Schemas {
    public class FileFullRepresentationsField {
        [JsonPropertyName("entries")]
        public IReadOnlyList<FileFullRepresentationsFieldEntriesField> Entries { get; }

        public FileFullRepresentationsField(IReadOnlyList<FileFullRepresentationsFieldEntriesField> entries) {
            Entries = entries;
        }
    }
}