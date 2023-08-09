using System.IO;
using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text.Json.Serialization;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class UpdateWebLinkAddSharedLinkRequestBodyArg {
        [JsonPropertyName("shared_link")]
        public UpdateWebLinkAddSharedLinkRequestBodyArgSharedLinkField SharedLink { get; }

        public UpdateWebLinkAddSharedLinkRequestBodyArg(UpdateWebLinkAddSharedLinkRequestBodyArgSharedLinkField sharedLink) {
            SharedLink = sharedLink;
        }
    }
}