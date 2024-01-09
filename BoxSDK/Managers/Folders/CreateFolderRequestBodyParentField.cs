using Unions;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class CreateFolderRequestBodyParentField {
        /// <summary>
        /// The ID of parent folder
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; }

        public CreateFolderRequestBodyParentField(string id) {
            Id = id;
        }
    }
}