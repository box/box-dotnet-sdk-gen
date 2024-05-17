using Unions;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Box.Sdk.Gen.Schemas;
using Box.Sdk.Gen;

namespace Box.Sdk.Gen.Managers {
    public class CreateFolderRequestBodyParentField {
        /// <summary>
        /// The ID of parent folder
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; }

        public CreateFolderRequestBodyParentField(string id) {
            Id = id;
        }
    }
}