using Unions;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Box.Sdk.Gen;
using Serializer;
using Box.Sdk.Gen.Schemas;

namespace Box.Sdk.Gen.Managers {
    public class RemoveSharedLinkFromFolderRequestBody {
        /// <summary>
        /// By setting this value to `null`, the shared link
        /// is removed from the folder.
        /// </summary>
        [JsonPropertyName("shared_link")]
        public RemoveSharedLinkFromFolderRequestBodySharedLinkField? SharedLink { get; init; }

        public RemoveSharedLinkFromFolderRequestBody() {
            
        }
    }
}