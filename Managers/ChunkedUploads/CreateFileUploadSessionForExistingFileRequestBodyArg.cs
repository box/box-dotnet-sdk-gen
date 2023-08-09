using System.IO;
using System.Text.Json.Serialization;
using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class CreateFileUploadSessionForExistingFileRequestBodyArg {
        [JsonPropertyName("file_size")]
        public int FileSize { get; }

        [JsonPropertyName("file_name")]
        public string FileName { get; }

        public CreateFileUploadSessionForExistingFileRequestBodyArg(int fileSize, string fileName) {
            FileSize = fileSize;
            FileName = fileName;
        }
    }
}