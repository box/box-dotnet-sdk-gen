using Unions;
using System.Text.Json.Serialization;
using Box.Sdk.Gen.Schemas;

namespace Box.Sdk.Gen.Schemas {
    public class FileMini : FileBase {
        [JsonPropertyName("sequence_id")]
        public string? SequenceId { get; init; }

        /// <summary>
        /// The name of the file
        /// </summary>
        [JsonPropertyName("name")]
        public string? Name { get; init; }

        /// <summary>
        /// The SHA1 hash of the file. This can be used to compare the contents
        /// of a file on Box with a local file.
        /// </summary>
        [JsonPropertyName("sha1")]
        public string? Sha1 { get; init; }

        [JsonPropertyName("file_version")]
        public FileVersionMini? FileVersion { get; init; }

        public FileMini(string id, FileBaseTypeField type = FileBaseTypeField.File) : base(id, type) {
            
        }
    }
}