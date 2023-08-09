using System.IO;
using Unions;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class UploadFileRequestBodyArg {
        [JsonPropertyName("attributes")]
        public UploadFileRequestBodyArgAttributesField Attributes { get; }

        [JsonPropertyName("file")]
        public Stream File { get; }

        [JsonPropertyName("fileFileName")]
        public string FileFileName { get; }

        [JsonPropertyName("fileContentType")]
        public string FileContentType { get; }

        public UploadFileRequestBodyArg(UploadFileRequestBodyArgAttributesField attributes, Stream file, string fileFileName, string fileContentType) {
            Attributes = attributes;
            File = file;
            FileFileName = fileFileName;
            FileContentType = fileContentType;
        }
    }
}