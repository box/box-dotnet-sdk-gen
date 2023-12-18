using Unions;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class AddShareLinkToFolderRequestBody {
        /// <summary>
        /// The settings for the shared link to create on the folder.
        /// 
        /// Use an empty object (`{}`) to use the default settings for shared
        /// links.
        /// </summary>
        [JsonPropertyName("shared_link")]
        public AddShareLinkToFolderRequestBodySharedLinkField? SharedLink { get; set; } = default;

        public AddShareLinkToFolderRequestBody() {
            
        }
    }
}