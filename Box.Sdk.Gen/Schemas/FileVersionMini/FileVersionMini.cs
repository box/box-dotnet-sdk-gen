using Unions;
using System.Text.Json.Serialization;
using Box.Sdk.Gen.Schemas;

namespace Box.Sdk.Gen.Schemas {
    public class FileVersionMini : FileVersionBase {
        /// <summary>
        /// The SHA1 hash of this version of the file.
        /// </summary>
        [JsonPropertyName("sha1")]
        public string? Sha1 { get; set; } = default;

        public FileVersionMini(string id, FileVersionBaseTypeField type = FileVersionBaseTypeField.FileVersion) : base(id, type) {
            
        }
    }
}