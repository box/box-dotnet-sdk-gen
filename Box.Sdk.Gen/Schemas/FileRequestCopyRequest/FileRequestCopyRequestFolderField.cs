using Box.Sdk.Gen;
using System.Text.Json.Serialization;
using Box.Sdk.Gen.Internal;
using Box.Sdk.Gen.Schemas;

namespace Box.Sdk.Gen.Schemas {
    public class FileRequestCopyRequestFolderField {
        /// <summary>
        /// `folder`
        /// </summary>
        [JsonPropertyName("type")]
        [JsonConverter(typeof(StringEnumConverter<FileRequestCopyRequestFolderTypeField>))]
        public StringEnum<FileRequestCopyRequestFolderTypeField>? Type { get; init; }

        /// <summary>
        /// The ID of the folder to associate the new
        /// file request to.
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; }

        public FileRequestCopyRequestFolderField(string id) {
            Id = id;
        }
    }
}