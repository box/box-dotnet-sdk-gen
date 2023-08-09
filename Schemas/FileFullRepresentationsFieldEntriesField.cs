using System.IO;
using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;

namespace Box.Schemas {
    public class FileFullRepresentationsFieldEntriesField {
        [JsonPropertyName("content")]
        public FileFullRepresentationsFieldEntriesFieldContentField Content { get; }

        [JsonPropertyName("info")]
        public FileFullRepresentationsFieldEntriesFieldInfoField Info { get; }

        [JsonPropertyName("properties")]
        public FileFullRepresentationsFieldEntriesFieldPropertiesField Properties { get; }

        [JsonPropertyName("representation")]
        public string Representation { get; }

        [JsonPropertyName("status")]
        public FileFullRepresentationsFieldEntriesFieldStatusField Status { get; }

        public FileFullRepresentationsFieldEntriesField(FileFullRepresentationsFieldEntriesFieldContentField content, FileFullRepresentationsFieldEntriesFieldInfoField info, FileFullRepresentationsFieldEntriesFieldPropertiesField properties, string representation, FileFullRepresentationsFieldEntriesFieldStatusField status) {
            Content = content;
            Info = info;
            Properties = properties;
            Representation = representation;
            Status = status;
        }
    }
}