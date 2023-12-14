using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class RestoreWeblinkFromTrashRequestBody {
        /// <summary>
        /// An optional new name for the web link.
        /// </summary>
        [JsonPropertyName("name")]
        public string? Name { get; set; } = default;

        [JsonPropertyName("parent")]
        public RestoreWeblinkFromTrashRequestBodyParentField? Parent { get; set; } = default;

        public RestoreWeblinkFromTrashRequestBody() {
            
        }
    }
}