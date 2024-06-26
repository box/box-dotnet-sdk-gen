using Unions;
using System.Text.Json.Serialization;
using Box.Sdk.Gen.Schemas;

namespace Box.Sdk.Gen.Schemas {
    public class FolderMini : FolderBase {
        [JsonPropertyName("sequence_id")]
        public string? SequenceId { get; init; }

        /// <summary>
        /// The name of the folder.
        /// </summary>
        [JsonPropertyName("name")]
        public string? Name { get; init; }

        public FolderMini(string id, FolderBaseTypeField type = FolderBaseTypeField.Folder) : base(id, type) {
            
        }
        
        [JsonConstructorAttribute]
        internal FolderMini(string id, StringEnum<FolderBaseTypeField> type) : base(id, type ?? new StringEnum<FolderBaseTypeField>(FolderBaseTypeField.Folder)) {
            
        }
    }
}