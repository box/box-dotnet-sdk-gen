using Unions;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class RemoveSharedLinkFromFolderRequestBody {
        /// <summary>
        /// By setting this value to `null`, the shared link
        /// is removed from the folder.
        /// </summary>
        [JsonPropertyName("shared_link")]
        public RemoveSharedLinkFromFolderRequestBodySharedLinkField? SharedLink { get; set; } = default;

        public RemoveSharedLinkFromFolderRequestBody() {
            
        }
    }
}