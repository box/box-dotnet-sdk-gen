using System.IO;
using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;

namespace Box.Schemas {
    public class FileRequestCopyRequestFolderField {
        /// <summary>
        /// `folder`
        /// </summary>
        [JsonPropertyName("type")]
        public FileRequestCopyRequestFolderFieldTypeField? Type { get; set; } = default;

        /// <summary>
        /// The ID of the folder to associate the new
        /// file request to.
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; }

        public FileRequestCopyRequestFolderField(string id) {
            Id = id;
        }
    }
}