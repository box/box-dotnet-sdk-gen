using System.IO;
using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text.Json.Serialization;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class UpdateWebLinkUpdateSharedLinkRequestBodyArg {
        [JsonPropertyName("shared_link")]
        public UpdateWebLinkUpdateSharedLinkRequestBodyArgSharedLinkField SharedLink { get; }

        public UpdateWebLinkUpdateSharedLinkRequestBodyArg(UpdateWebLinkUpdateSharedLinkRequestBodyArgSharedLinkField sharedLink) {
            SharedLink = sharedLink;
        }
    }
}