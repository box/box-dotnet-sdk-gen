using Box.Sdk.Gen;
using System.Text.Json.Serialization;
using Box.Sdk.Gen.Schemas;

namespace Box.Sdk.Gen.Schemas {
    public class FileVersionMini : FileVersionBase {
        /// <summary>
        /// The SHA1 hash of this version of the file.
        /// </summary>
        [JsonPropertyName("sha1")]
        public string? Sha1 { get; init; }

        public FileVersionMini(string id, FileVersionBaseTypeField type = FileVersionBaseTypeField.FileVersion) : base(id, type) {
            
        }
        
        [JsonConstructorAttribute]
        internal FileVersionMini(string id, StringEnum<FileVersionBaseTypeField> type) : base(id, type ?? new StringEnum<FileVersionBaseTypeField>(FileVersionBaseTypeField.FileVersion)) {
            
        }
    }
}