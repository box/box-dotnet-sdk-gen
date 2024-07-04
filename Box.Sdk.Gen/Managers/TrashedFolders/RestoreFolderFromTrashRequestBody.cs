using Box.Sdk.Gen;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using Box.Sdk.Gen.Schemas;
using Box.Sdk.Gen.Internal;

namespace Box.Sdk.Gen.Managers {
    public class RestoreFolderFromTrashRequestBody {
        /// <summary>
        /// An optional new name for the folder.
        /// </summary>
        [JsonPropertyName("name")]
        public string? Name { get; init; }

        [JsonPropertyName("parent")]
        public RestoreFolderFromTrashRequestBodyParentField? Parent { get; init; }

        public RestoreFolderFromTrashRequestBody() {
            
        }
    }
}