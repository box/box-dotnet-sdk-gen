using Box.Sdk.Gen;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Box.Sdk.Gen.Internal;
using Box.Sdk.Gen.Schemas;

namespace Box.Sdk.Gen.Managers {
    public class RemoveSharedLinkFromWebLinkRequestBody {
        /// <summary>
        /// By setting this value to `null`, the shared link
        /// is removed from the web link.
        /// </summary>
        [JsonPropertyName("shared_link")]
        public RemoveSharedLinkFromWebLinkRequestBodySharedLinkField? SharedLink { get; init; }

        public RemoveSharedLinkFromWebLinkRequestBody() {
            
        }
    }
}