using Unions;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Box.Sdk.Gen.Schemas;
using Box.Sdk.Gen;

namespace Box.Sdk.Gen.Managers {
    public class AddShareLinkToFileRequestBody {
        /// <summary>
        /// The settings for the shared link to create on the file.
        /// Use an empty object (`{}`) to use the default settings for shared
        /// links.
        /// </summary>
        [JsonPropertyName("shared_link")]
        public AddShareLinkToFileRequestBodySharedLinkField? SharedLink { get; init; }

        public AddShareLinkToFileRequestBody() {
            
        }
    }
}