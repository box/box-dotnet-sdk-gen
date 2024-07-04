using Box.Sdk.Gen;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Box.Sdk.Gen.Internal;
using Box.Sdk.Gen.Schemas;

namespace Box.Sdk.Gen.Managers {
    public class AddShareLinkToFolderRequestBody {
        /// <summary>
        /// The settings for the shared link to create on the folder.
        /// 
        /// Use an empty object (`{}`) to use the default settings for shared
        /// links.
        /// </summary>
        [JsonPropertyName("shared_link")]
        public AddShareLinkToFolderRequestBodySharedLinkField? SharedLink { get; init; }

        public AddShareLinkToFolderRequestBody() {
            
        }
    }
}