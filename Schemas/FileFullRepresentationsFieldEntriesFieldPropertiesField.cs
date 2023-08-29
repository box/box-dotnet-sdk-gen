using System.IO;
using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;

namespace Box.Schemas {
    public class FileFullRepresentationsFieldEntriesFieldPropertiesField {
        /// <summary>
        /// The width by height size of this representation in pixels.
        /// </summary>
        [JsonPropertyName("dimensions")]
        public string? Dimensions { get; set; } = default;

        /// <summary>
        /// Indicates if the representation is build up out of multiple
        /// pages.
        /// </summary>
        [JsonPropertyName("paged")]
        public bool? Paged { get; set; } = default;

        /// <summary>
        /// Indicates if the representation can be used as a thumbnail of
        /// the file.
        /// </summary>
        [JsonPropertyName("thumb")]
        public bool? Thumb { get; set; } = default;

        public FileFullRepresentationsFieldEntriesFieldPropertiesField() {
            
        }
    }
}