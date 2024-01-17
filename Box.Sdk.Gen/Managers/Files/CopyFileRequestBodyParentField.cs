using Unions;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Box.Sdk.Gen.Schemas;
using Box.Sdk.Gen;

namespace Box.Sdk.Gen.Managers {
    public class CopyFileRequestBodyParentField {
        /// <summary>
        /// The ID of folder to copy the file to.
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; }

        public CopyFileRequestBodyParentField(string id) {
            Id = id;
        }
    }
}