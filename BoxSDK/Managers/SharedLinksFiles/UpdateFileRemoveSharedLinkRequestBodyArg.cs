using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text.Json.Serialization;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class UpdateFileRemoveSharedLinkRequestBodyArg {
        /// <summary>
        /// By setting this value to `null`, the shared link
        /// is removed from the file.
        /// </summary>
        [JsonPropertyName("shared_link")]
        public UpdateFileRemoveSharedLinkRequestBodyArgSharedLinkField? SharedLink { get; set; } = default;

        public UpdateFileRemoveSharedLinkRequestBodyArg() {
            
        }
    }
}