using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Text.Json;

namespace Box.Sdk.Gen.Schemas {
    public class FileFullRepresentationsEntriesField {
        /// <summary>
        /// An object containing the URL that can be used to actually fetch
        /// the representation.
        /// </summary>
        [JsonPropertyName("content")]
        public FileFullRepresentationsEntriesContentField? Content { get; set; } = default;

        /// <summary>
        /// An object containing the URL that can be used to fetch more info
        /// on this representation.
        /// </summary>
        [JsonPropertyName("info")]
        public FileFullRepresentationsEntriesInfoField? Info { get; set; } = default;

        /// <summary>
        /// An object containing the size and type of this presentation.
        /// </summary>
        [JsonPropertyName("properties")]
        public FileFullRepresentationsEntriesPropertiesField? Properties { get; set; } = default;

        /// <summary>
        /// Indicates the file type of the returned representation.
        /// </summary>
        [JsonPropertyName("representation")]
        public string? Representation { get; set; } = default;

        /// <summary>
        /// An object containing the status of this representation.
        /// </summary>
        [JsonPropertyName("status")]
        public FileFullRepresentationsEntriesStatusField? Status { get; set; } = default;

        public FileFullRepresentationsEntriesField() {
            
        }
    }
}