using System.Text.Json.Serialization;
using Unions;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class TransferOwnedFolderRequestBodyOwnedByField {
        /// <summary>
        /// The ID of the user who the folder will be
        /// transferred to
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; }

        public TransferOwnedFolderRequestBodyOwnedByField(string id) {
            Id = id;
        }
    }
}