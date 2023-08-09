using System.IO;
using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;

namespace Box.Schemas {
    public class FileFullRepresentationsFieldEntriesFieldStatusField {
        [JsonPropertyName("state")]
        public FileFullRepresentationsFieldEntriesFieldStatusFieldStateField State { get; }

        public FileFullRepresentationsFieldEntriesFieldStatusField(FileFullRepresentationsFieldEntriesFieldStatusFieldStateField state) {
            State = state;
        }
    }
}