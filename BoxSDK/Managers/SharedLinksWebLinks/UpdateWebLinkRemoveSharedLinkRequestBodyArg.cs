using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text.Json.Serialization;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class UpdateWebLinkRemoveSharedLinkRequestBodyArg {
        /// <summary>
        /// By setting this value to `null`, the shared link
        /// is removed from the web link.
        /// </summary>
        [JsonPropertyName("shared_link")]
        public UpdateWebLinkRemoveSharedLinkRequestBodyArgSharedLinkField? SharedLink { get; set; } = default;

        public UpdateWebLinkRemoveSharedLinkRequestBodyArg() {
            
        }
    }
}