using System.Text.Json.Serialization;
using Unions;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class TransferOwnedFolderRequestBody {
        /// <summary>
        /// The user who the folder will be transferred to
        /// </summary>
        [JsonPropertyName("owned_by")]
        public TransferOwnedFolderRequestBodyOwnedByField OwnedBy { get; set; }

        public TransferOwnedFolderRequestBody(TransferOwnedFolderRequestBodyOwnedByField ownedBy) {
            OwnedBy = ownedBy;
        }
    }
}