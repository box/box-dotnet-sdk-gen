using System.IO;
using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text.Json.Serialization;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class UpdateWebLinkRemoveSharedLinkRequestBodyArg {
        [JsonPropertyName("shared_link")]
        public UpdateWebLinkRemoveSharedLinkRequestBodyArgSharedLinkField SharedLink { get; }

        public UpdateWebLinkRemoveSharedLinkRequestBodyArg(UpdateWebLinkRemoveSharedLinkRequestBodyArgSharedLinkField sharedLink) {
            SharedLink = sharedLink;
        }
    }
}