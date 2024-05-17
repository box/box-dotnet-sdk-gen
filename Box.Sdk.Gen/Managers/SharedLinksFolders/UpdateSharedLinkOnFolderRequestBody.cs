using Unions;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Box.Sdk.Gen.Schemas;
using Box.Sdk.Gen;

namespace Box.Sdk.Gen.Managers {
    public class UpdateSharedLinkOnFolderRequestBody {
        /// <summary>
        /// The settings for the shared link to update.
        /// </summary>
        [JsonPropertyName("shared_link")]
        public UpdateSharedLinkOnFolderRequestBodySharedLinkField? SharedLink { get; init; }

        public UpdateSharedLinkOnFolderRequestBody() {
            
        }
    }
}