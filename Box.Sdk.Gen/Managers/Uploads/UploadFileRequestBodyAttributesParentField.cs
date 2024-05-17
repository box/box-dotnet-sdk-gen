using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using Box.Sdk.Gen.Schemas;
using Box.Sdk.Gen;

namespace Box.Sdk.Gen.Managers {
    public class UploadFileRequestBodyAttributesParentField {
        /// <summary>
        /// The id of the parent folder. Use
        /// `0` for the user's root folder.
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; }

        public UploadFileRequestBodyAttributesParentField(string id) {
            Id = id;
        }
    }
}