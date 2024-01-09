using Unions;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Box.Schemas;
using Box;

namespace Box.Managers {
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