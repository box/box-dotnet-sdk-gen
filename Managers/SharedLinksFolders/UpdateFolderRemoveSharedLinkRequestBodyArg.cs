using System.IO;
using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text.Json.Serialization;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class UpdateFolderRemoveSharedLinkRequestBodyArg {
        [JsonPropertyName("shared_link")]
        public UpdateFolderRemoveSharedLinkRequestBodyArgSharedLinkField SharedLink { get; }

        public UpdateFolderRemoveSharedLinkRequestBodyArg(UpdateFolderRemoveSharedLinkRequestBodyArgSharedLinkField sharedLink) {
            SharedLink = sharedLink;
        }
    }
}