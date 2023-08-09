using System.IO;
using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text.Json.Serialization;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class UpdateFolderAddSharedLinkRequestBodyArg {
        [JsonPropertyName("shared_link")]
        public UpdateFolderAddSharedLinkRequestBodyArgSharedLinkField SharedLink { get; }

        public UpdateFolderAddSharedLinkRequestBodyArg(UpdateFolderAddSharedLinkRequestBodyArgSharedLinkField sharedLink) {
            SharedLink = sharedLink;
        }
    }
}