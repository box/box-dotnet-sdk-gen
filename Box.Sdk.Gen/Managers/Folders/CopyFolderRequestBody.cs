using Unions;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Box.Sdk.Gen.Schemas;
using Box.Sdk.Gen;

namespace Box.Sdk.Gen.Managers {
    public class CopyFolderRequestBody {
        /// <summary>
        /// An optional new name for the copied folder.
        /// 
        /// There are some restrictions to the file name. Names containing
        /// non-printable ASCII characters, forward and backward slashes
        /// (`/`, `\`), as well as names with trailing spaces are
        /// prohibited.
        /// 
        /// Additionally, the names `.` and `..` are
        /// not allowed either.
        /// </summary>
        [JsonPropertyName("name")]
        public string? Name { get; set; } = default;

        /// <summary>
        /// The destination folder to copy the folder to.
        /// </summary>
        [JsonPropertyName("parent")]
        public CopyFolderRequestBodyParentField Parent { get; set; }

        public CopyFolderRequestBody(CopyFolderRequestBodyParentField parent) {
            Parent = parent;
        }
    }
}