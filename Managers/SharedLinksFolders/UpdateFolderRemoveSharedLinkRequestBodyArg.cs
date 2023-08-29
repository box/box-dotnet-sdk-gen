using System.IO;
using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text.Json.Serialization;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class UpdateFolderRemoveSharedLinkRequestBodyArg {
        /// <summary>
        /// By setting this value to `null`, the shared link
        /// is removed from the folder.
        /// </summary>
        [JsonPropertyName("shared_link")]
        public UpdateFolderRemoveSharedLinkRequestBodyArgSharedLinkField? SharedLink { get; set; } = default;

        public UpdateFolderRemoveSharedLinkRequestBodyArg() {
            
        }
    }
}