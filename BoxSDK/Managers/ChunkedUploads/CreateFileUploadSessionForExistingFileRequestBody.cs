using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Unions;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class CreateFileUploadSessionForExistingFileRequestBody {
        /// <summary>
        /// The total number of bytes of the file to be uploaded
        /// </summary>
        [JsonPropertyName("file_size")]
        public long FileSize { get; set; }

        /// <summary>
        /// The optional new name of new file
        /// </summary>
        [JsonPropertyName("file_name")]
        public string? FileName { get; set; } = default;

        public CreateFileUploadSessionForExistingFileRequestBody(long fileSize) {
            FileSize = fileSize;
        }
    }
}