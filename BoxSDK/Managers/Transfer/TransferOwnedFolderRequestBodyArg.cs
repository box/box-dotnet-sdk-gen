using System.Text.Json.Serialization;
using Unions;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
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