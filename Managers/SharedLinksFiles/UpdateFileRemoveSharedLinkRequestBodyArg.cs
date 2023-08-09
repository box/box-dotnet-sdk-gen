using System.IO;
using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text.Json.Serialization;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class UpdateFileRemoveSharedLinkRequestBodyArg {
        [JsonPropertyName("shared_link")]
        public UpdateFileRemoveSharedLinkRequestBodyArgSharedLinkField SharedLink { get; }

        public UpdateFileRemoveSharedLinkRequestBodyArg(UpdateFileRemoveSharedLinkRequestBodyArgSharedLinkField sharedLink) {
            SharedLink = sharedLink;
        }
    }
}