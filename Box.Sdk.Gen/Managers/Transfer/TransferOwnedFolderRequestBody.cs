using System.Text.Json.Serialization;
using Box.Sdk.Gen;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using Box.Sdk.Gen.Schemas;
using Box.Sdk.Gen.Internal;

namespace Box.Sdk.Gen.Managers {
    public class TransferOwnedFolderRequestBody {
        /// <summary>
        /// The user who the folder will be transferred to
        /// </summary>
        [JsonPropertyName("owned_by")]
        public TransferOwnedFolderRequestBodyOwnedByField OwnedBy { get; }

        public TransferOwnedFolderRequestBody(TransferOwnedFolderRequestBodyOwnedByField ownedBy) {
            OwnedBy = ownedBy;
        }
    }
}