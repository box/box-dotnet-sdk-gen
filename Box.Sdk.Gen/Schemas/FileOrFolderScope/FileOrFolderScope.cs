using Box.Sdk.Gen;
using System.Text.Json.Serialization;
using Box.Sdk.Gen.Internal;
using Box.Sdk.Gen.Schemas;

namespace Box.Sdk.Gen.Schemas {
    public class FileOrFolderScope {
        /// <summary>
        /// The scopes for the resource access
        /// </summary>
        [JsonPropertyName("scope")]
        [JsonConverter(typeof(StringEnumConverter<FileOrFolderScopeScopeField>))]
        public StringEnum<FileOrFolderScopeScopeField>? Scope { get; init; }

        [JsonPropertyName("object")]
        public FileMiniOrFolderMini? Object { get; init; }

        public FileOrFolderScope() {
            
        }
    }
}