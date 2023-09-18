using System.Text.Json.Serialization;
using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class CreateFileUploadSessionForExistingFileRequestBodyArg {
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

        public CreateFileUploadSessionForExistingFileRequestBodyArg(long fileSize) {
            FileSize = fileSize;
        }
    }
}