using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;

namespace Box.Schemas {
    public class FileVersionMini : FileVersionBase {
        /// <summary>
        /// The SHA1 hash of this version of the file.
        /// </summary>
        [JsonPropertyName("sha1")]
        public string? Sha1 { get; set; } = default;

        public FileVersionMini(string id, FileVersionBaseTypeField type) : base(id, type) {
            
        }
    }
}