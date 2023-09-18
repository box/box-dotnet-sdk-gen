using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;

namespace Box.Schemas {
    public class FileMini : FileBase {
        [JsonPropertyName("sequence_id")]
        public string? SequenceId { get; set; } = default;

        /// <summary>
        /// The name of the file
        /// </summary>
        [JsonPropertyName("name")]
        public string? Name { get; set; } = default;

        /// <summary>
        /// The SHA1 hash of the file. This can be used to compare the contents
        /// of a file on Box with a local file.
        /// </summary>
        [JsonPropertyName("sha1")]
        public string? Sha1 { get; set; } = default;

        [JsonPropertyName("file_version")]
        public FileVersionMini? FileVersion { get; set; } = default;

        public FileMini(string id, FileBaseTypeField type) : base(id, type) {
            
        }
    }
}