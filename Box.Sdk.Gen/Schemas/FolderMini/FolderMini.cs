using Unions;
using System.Text.Json.Serialization;
using Box.Sdk.Gen.Schemas;

namespace Box.Sdk.Gen.Schemas {
    public class FolderMini : FolderBase {
        [JsonPropertyName("sequence_id")]
        public string? SequenceId { get; set; } = default;

        /// <summary>
        /// The name of the folder.
        /// </summary>
        [JsonPropertyName("name")]
        public string? Name { get; set; } = default;

        public FolderMini(string id, FolderBaseTypeField type = FolderBaseTypeField.Folder) : base(id, type) {
            
        }
    }
}