using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text.Json.Serialization;
using System;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class CopyFolderRequestBodyArgParentField {
        /// <summary>
        /// The ID of parent folder
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; }

        public CopyFolderRequestBodyArgParentField(string id) {
            Id = id;
        }
    }
}