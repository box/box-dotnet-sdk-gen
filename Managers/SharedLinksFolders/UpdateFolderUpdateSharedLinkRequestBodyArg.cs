using System.IO;
using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text.Json.Serialization;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class UpdateFolderUpdateSharedLinkRequestBodyArg {
        [JsonPropertyName("shared_link")]
        public UpdateFolderUpdateSharedLinkRequestBodyArgSharedLinkField SharedLink { get; }

        public UpdateFolderUpdateSharedLinkRequestBodyArg(UpdateFolderUpdateSharedLinkRequestBodyArgSharedLinkField sharedLink) {
            SharedLink = sharedLink;
        }
    }
}