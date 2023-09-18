using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Text.Json;

namespace Box.Schemas {
    public class ZipDownloadNameConflictsField {
        /// <summary>
        /// The identifier of the item
        /// </summary>
        [JsonPropertyName("id")]
        public string? Id { get; set; } = default;

        /// <summary>
        /// The type of this item
        /// </summary>
        [JsonPropertyName("type")]
        public ZipDownloadNameConflictsFieldTypeField? Type { get; set; } = default;

        /// <summary>
        /// The original name of this item
        /// </summary>
        [JsonPropertyName("original_name")]
        public string? OriginalName { get; set; } = default;

        /// <summary>
        /// The new name of this item as it will appear in the
        /// downloaded `zip` archive.
        /// </summary>
        [JsonPropertyName("download_name")]
        public string? DownloadName { get; set; } = default;

        public ZipDownloadNameConflictsField() {
            
        }
    }
}