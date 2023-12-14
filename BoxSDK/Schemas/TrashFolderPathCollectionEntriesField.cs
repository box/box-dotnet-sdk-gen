using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Text.Json;

namespace Box.Schemas {
    public class TrashFolderPathCollectionEntriesField {
        /// <summary>
        /// `folder`
        /// </summary>
        [JsonPropertyName("type")]
        public TrashFolderPathCollectionEntriesTypeField? Type { get; set; } = default;

        /// <summary>
        /// The unique identifier that represent a folder.
        /// </summary>
        [JsonPropertyName("id")]
        public string? Id { get; set; } = default;

        /// <summary>
        /// This field is null for the Trash folder
        /// </summary>
        [JsonPropertyName("sequence_id")]
        public string? SequenceId { get; set; } = default;

        /// <summary>
        /// This field is null for the Trash folder
        /// </summary>
        [JsonPropertyName("etag")]
        public string? Etag { get; set; } = default;

        /// <summary>
        /// The name of the Trash folder.
        /// </summary>
        [JsonPropertyName("name")]
        public string? Name { get; set; } = default;

        public TrashFolderPathCollectionEntriesField() {
            
        }
    }
}