using Unions;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class UpdateFileAddSharedLinkRequestBody {
        /// <summary>
        /// The settings for the shared link to create on the file.
        /// Use an empty object (`{}`) to use the default settings for shared
        /// links.
        /// </summary>
        [JsonPropertyName("shared_link")]
        public UpdateFileAddSharedLinkRequestBodySharedLinkField? SharedLink { get; set; } = default;

        public UpdateFileAddSharedLinkRequestBody() {
            
        }
    }
}