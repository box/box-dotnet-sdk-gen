using Unions;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class UpdateFileRemoveSharedLinkRequestBody {
        /// <summary>
        /// By setting this value to `null`, the shared link
        /// is removed from the file.
        /// </summary>
        [JsonPropertyName("shared_link")]
        public UpdateFileRemoveSharedLinkRequestBodySharedLinkField? SharedLink { get; set; } = default;

        public UpdateFileRemoveSharedLinkRequestBody() {
            
        }
    }
}