using System.Text.Json.Serialization;
using Box.Sdk.Gen;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using Box.Sdk.Gen.Schemas;
using Box.Sdk.Gen.Internal;

namespace Box.Sdk.Gen.Managers {
    public class TransferOwnedFolderRequestBodyOwnedByField {
        /// <summary>
        /// The ID of the user who the folder will be
        /// transferred to
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; }

        public TransferOwnedFolderRequestBodyOwnedByField(string id) {
            Id = id;
        }
    }
}