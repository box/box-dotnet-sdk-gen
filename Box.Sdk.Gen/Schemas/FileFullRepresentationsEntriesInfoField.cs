using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Text.Json;

namespace Box.Sdk.Gen.Schemas {
    public class FileFullRepresentationsEntriesInfoField {
        /// <summary>
        /// The API URL that can be used to get more info on this file
        /// representation. Make sure to make an authenticated API call
        /// to this endpoint.
        /// </summary>
        [JsonPropertyName("url")]
        public string? Url { get; set; } = default;

        public FileFullRepresentationsEntriesInfoField() {
            
        }
    }
}