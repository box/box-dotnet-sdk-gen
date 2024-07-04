using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Box.Sdk.Gen;
using Box.Sdk.Gen.Schemas;
using Box.Sdk.Gen.Internal;

namespace Box.Sdk.Gen.Managers {
    public class CreateFileUploadSessionForExistingFileRequestBody {
        /// <summary>
        /// The total number of bytes of the file to be uploaded
        /// </summary>
        [JsonPropertyName("file_size")]
        public long FileSize { get; }

        /// <summary>
        /// The optional new name of new file
        /// </summary>
        [JsonPropertyName("file_name")]
        public string? FileName { get; init; }

        public CreateFileUploadSessionForExistingFileRequestBody(long fileSize) {
            FileSize = fileSize;
        }
    }
}