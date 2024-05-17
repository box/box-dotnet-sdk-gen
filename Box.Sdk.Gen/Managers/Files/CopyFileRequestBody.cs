using Unions;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Box.Sdk.Gen.Schemas;
using Box.Sdk.Gen;

namespace Box.Sdk.Gen.Managers {
    public class CopyFileRequestBody {
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
        public string? Name { get; init; }

        /// <summary>
        /// An optional ID of the specific file version to copy.
        /// </summary>
        [JsonPropertyName("version")]
        public string? Version { get; init; }

        /// <summary>
        /// The destination folder to copy the file to.
        /// </summary>
        [JsonPropertyName("parent")]
        public CopyFileRequestBodyParentField Parent { get; }

        public CopyFileRequestBody(CopyFileRequestBodyParentField parent) {
            Parent = parent;
        }
    }
}