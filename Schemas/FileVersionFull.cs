using System.IO;
using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;

namespace Box.Schemas {
    public class FileVersionFull : FileVersion {
        /// <summary>
        /// The version number of this file version
        /// </summary>
        [JsonPropertyName("version_number")]
        public string? VersionNumber { get; set; } = default;

        public FileVersionFull(string id, FileVersionBaseTypeField type) : base(id, type) {
            
        }
    }
}