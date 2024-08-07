using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Box.Sdk.Gen;
using Box.Sdk.Gen.Schemas;
using Box.Sdk.Gen.Internal;

namespace Box.Sdk.Gen.Managers {
    public class CreateFileUploadSessionRequestBody {
        /// <summary>
        /// The ID of the folder to upload the new file to.
        /// </summary>
        [JsonPropertyName("folder_id")]
        public string FolderId { get; }

        /// <summary>
        /// The total number of bytes of the file to be uploaded
        /// </summary>
        [JsonPropertyName("file_size")]
        public long FileSize { get; }

        /// <summary>
        /// The name of new file
        /// </summary>
        [JsonPropertyName("file_name")]
        public string FileName { get; }

        public CreateFileUploadSessionRequestBody(string folderId, long fileSize, string fileName) {
            FolderId = folderId;
            FileSize = fileSize;
            FileName = fileName;
        }
    }
}