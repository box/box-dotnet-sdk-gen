using System.IO;
using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text.Json.Serialization;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class UpdateFileAddSharedLinkRequestBodyArg {
        [JsonPropertyName("shared_link")]
        public UpdateFileAddSharedLinkRequestBodyArgSharedLinkField SharedLink { get; }

        public UpdateFileAddSharedLinkRequestBodyArg(UpdateFileAddSharedLinkRequestBodyArgSharedLinkField sharedLink) {
            SharedLink = sharedLink;
        }
    }
}