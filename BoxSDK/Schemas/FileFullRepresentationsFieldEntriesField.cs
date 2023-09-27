using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Text.Json;

namespace Box.Schemas {
    public class FileFullRepresentationsFieldEntriesField {
        /// <summary>
        /// An object containing the URL that can be used to actually fetch
        /// the representation.
        /// </summary>
        [JsonPropertyName("content")]
        public FileFullRepresentationsFieldEntriesFieldContentField? Content { get; set; } = default;

        /// <summary>
        /// An object containing the URL that can be used to fetch more info
        /// on this representation.
        /// </summary>
        [JsonPropertyName("info")]
        public FileFullRepresentationsFieldEntriesFieldInfoField? Info { get; set; } = default;

        /// <summary>
        /// An object containing the size and type of this presentation.
        /// </summary>
        [JsonPropertyName("properties")]
        public FileFullRepresentationsFieldEntriesFieldPropertiesField? Properties { get; set; } = default;

        /// <summary>
        /// Indicates the file type of the returned representation.
        /// </summary>
        [JsonPropertyName("representation")]
        public string? Representation { get; set; } = default;

        /// <summary>
        /// An object containing the status of this representation.
        /// </summary>
        [JsonPropertyName("status")]
        public FileFullRepresentationsFieldEntriesFieldStatusField? Status { get; set; } = default;

        public FileFullRepresentationsFieldEntriesField() {
            
        }
    }
}