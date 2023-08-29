using System.IO;
using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text.Json.Serialization;
using System;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class CopyFolderRequestBodyArg {
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
        public CopyFolderRequestBodyArgParentField Parent { get; set; }

        public CopyFolderRequestBodyArg(CopyFolderRequestBodyArgParentField parent) {
            Parent = parent;
        }
    }
}