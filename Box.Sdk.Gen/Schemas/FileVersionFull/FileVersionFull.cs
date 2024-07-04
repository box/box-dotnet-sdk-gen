using Box.Sdk.Gen;
using System.Text.Json.Serialization;
using Box.Sdk.Gen.Schemas;

namespace Box.Sdk.Gen.Schemas {
    public class FileVersionFull : FileVersion {
        /// <summary>
        /// The version number of this file version
        /// </summary>
        [JsonPropertyName("version_number")]
        public string? VersionNumber { get; init; }

        public FileVersionFull(string id, FileVersionBaseTypeField type = FileVersionBaseTypeField.FileVersion) : base(id, type) {
            
        }
        
        [JsonConstructorAttribute]
        internal FileVersionFull(string id, StringEnum<FileVersionBaseTypeField> type) : base(id, type ?? new StringEnum<FileVersionBaseTypeField>(FileVersionBaseTypeField.FileVersion)) {
            
        }
    }
}