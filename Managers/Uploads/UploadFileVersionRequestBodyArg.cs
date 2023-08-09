using System.IO;
using Unions;
using System.Text.Json.Serialization;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class UploadFileVersionRequestBodyArg {
        [JsonPropertyName("attributes")]
        public UploadFileVersionRequestBodyArgAttributesField Attributes { get; }

        [JsonPropertyName("file")]
        public Stream File { get; }

        [JsonPropertyName("fileFileName")]
        public string FileFileName { get; }

        [JsonPropertyName("fileContentType")]
        public string FileContentType { get; }

        public UploadFileVersionRequestBodyArg(UploadFileVersionRequestBodyArgAttributesField attributes, Stream file, string fileFileName, string fileContentType) {
            Attributes = attributes;
            File = file;
            FileFileName = fileFileName;
            FileContentType = fileContentType;
        }
    }
}