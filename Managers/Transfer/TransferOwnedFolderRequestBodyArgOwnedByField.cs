using System.IO;
using System.Text.Json.Serialization;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class TransferOwnedFolderRequestBodyArgOwnedByField {
        [JsonPropertyName("id")]
        public string Id { get; }

        public TransferOwnedFolderRequestBodyArgOwnedByField(string id) {
            Id = id;
        }
    }
}