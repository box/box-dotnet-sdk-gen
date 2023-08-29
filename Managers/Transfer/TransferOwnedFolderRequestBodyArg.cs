using System.IO;
using System.Text.Json.Serialization;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class TransferOwnedFolderRequestBodyArg {
        /// <summary>
        /// The user who the folder will be transferred to
        /// </summary>
        [JsonPropertyName("owned_by")]
        public TransferOwnedFolderRequestBodyArgOwnedByField OwnedBy { get; set; }

        public TransferOwnedFolderRequestBodyArg(TransferOwnedFolderRequestBodyArgOwnedByField ownedBy) {
            OwnedBy = ownedBy;
        }
    }
}