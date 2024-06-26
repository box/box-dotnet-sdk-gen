using Unions;
using Box.Sdk.Gen;
using System.Text.Json.Serialization;
using Serializer;
using Box.Sdk.Gen.Schemas;

namespace Box.Sdk.Gen.Schemas {
    public class FileRequestCopyRequest : FileRequestUpdateRequest {
        /// <summary>
        /// The folder to associate the new file request to.
        /// </summary>
        [JsonPropertyName("folder")]
        public FileRequestCopyRequestFolderField Folder { get; }

        public FileRequestCopyRequest(FileRequestCopyRequestFolderField folder) {
            Folder = folder;
        }
    }
}