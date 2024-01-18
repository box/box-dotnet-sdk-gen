using Unions;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Box.Sdk.Gen.Schemas;
using Box.Sdk.Gen;

namespace Box.Sdk.Gen.Managers {
    public class RemoveSharedLinkFromFileRequestBody {
        /// <summary>
        /// By setting this value to `null`, the shared link
        /// is removed from the file.
        /// </summary>
        [JsonPropertyName("shared_link")]
        public RemoveSharedLinkFromFileRequestBodySharedLinkField? SharedLink { get; set; } = default;

        public RemoveSharedLinkFromFileRequestBody() {
            
        }
    }
}