using System.IO;
using System.Text.Json.Serialization;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class TransferOwnedFolderRequestBodyArg {
        [JsonPropertyName("owned_by")]
        public TransferOwnedFolderRequestBodyArgOwnedByField OwnedBy { get; }

        public TransferOwnedFolderRequestBodyArg(TransferOwnedFolderRequestBodyArgOwnedByField ownedBy) {
            OwnedBy = ownedBy;
        }
    }
}