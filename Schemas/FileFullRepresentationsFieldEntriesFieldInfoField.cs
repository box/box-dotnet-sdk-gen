using System.IO;
using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;

namespace Box.Schemas {
    public class FileFullRepresentationsFieldEntriesFieldInfoField {
        [JsonPropertyName("url")]
        public string Url { get; }

        public FileFullRepresentationsFieldEntriesFieldInfoField(string url) {
            Url = url;
        }
    }
}