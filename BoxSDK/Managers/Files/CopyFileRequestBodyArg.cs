using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text.Json.Serialization;
using System;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class CopyFileRequestBodyArg {
        /// <summary>
        /// An optional new name for the copied file.
        /// 
        /// There are some restrictions to the file name. Names containing
        /// non-printable ASCII characters, forward and backward slashes
        /// (`/`, `\`), and protected names like `.` and `..` are
        /// automatically sanitized by removing the non-allowed
        /// characters.
        /// </summary>
        [JsonPropertyName("name")]
        public string? Name { get; set; } = default;

        /// <summary>
        /// An optional ID of the specific file version to copy.
        /// </summary>
        [JsonPropertyName("version")]
        public string? Version { get; set; } = default;

        /// <summary>
        /// The destination folder to copy the file to.
        /// </summary>
        [JsonPropertyName("parent")]
        public CopyFileRequestBodyArgParentField Parent { get; set; }

        public CopyFileRequestBodyArg(CopyFileRequestBodyArgParentField parent) {
            Parent = parent;
        }
    }
}