using Unions;
using System.Text.Json.Serialization;

namespace Box.Sdk.Gen.Schemas {
    public class FileVersionBase {
        /// <summary>
        /// The unique identifier that represent a file version.
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; }

        /// <summary>
        /// `file_version`
        /// </summary>
        [JsonPropertyName("type")]
        public FileVersionBaseTypeField Type { get; }

        public FileVersionBase(string id, FileVersionBaseTypeField type = FileVersionBaseTypeField.FileVersion) {
            Id = id;
            Type = type;
        }
    }
}