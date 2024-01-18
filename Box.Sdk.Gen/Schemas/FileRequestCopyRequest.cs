using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;

namespace Box.Sdk.Gen.Schemas {
    public class FileRequestCopyRequest : FileRequestUpdateRequest {
        /// <summary>
        /// The folder to associate the new file request to.
        /// </summary>
        [JsonPropertyName("folder")]
        public FileRequestCopyRequestFolderField Folder { get; set; }

        public FileRequestCopyRequest(FileRequestCopyRequestFolderField folder) {
            Folder = folder;
        }
    }
}