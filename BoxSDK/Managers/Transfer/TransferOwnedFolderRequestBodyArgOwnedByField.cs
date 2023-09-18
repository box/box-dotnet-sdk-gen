using System.Text.Json.Serialization;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class TransferOwnedFolderRequestBodyArgOwnedByField {
        /// <summary>
        /// The ID of the user who the folder will be
        /// transferred to
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; }

        public TransferOwnedFolderRequestBodyArgOwnedByField(string id) {
            Id = id;
        }
    }
}