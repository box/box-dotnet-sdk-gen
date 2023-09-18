using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text.Json.Serialization;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class UpdateFileUpdateSharedLinkRequestBodyArg {
        /// <summary>
        /// The settings for the shared link to update.
        /// </summary>
        [JsonPropertyName("shared_link")]
        public UpdateFileUpdateSharedLinkRequestBodyArgSharedLinkField? SharedLink { get; set; } = default;

        public UpdateFileUpdateSharedLinkRequestBodyArg() {
            
        }
    }
}