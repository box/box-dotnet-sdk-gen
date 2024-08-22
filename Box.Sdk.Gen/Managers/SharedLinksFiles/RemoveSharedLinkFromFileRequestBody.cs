using Box.Sdk.Gen;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Box.Sdk.Gen.Internal;
using Box.Sdk.Gen.Schemas;

namespace Box.Sdk.Gen.Managers {
    public class RemoveSharedLinkFromFileRequestBody {
        [JsonInclude]
        [JsonPropertyName("_isshared_linkSet")]
        protected bool _isSharedLinkSet { get; set; }

        protected RemoveSharedLinkFromFileRequestBodySharedLinkField? _sharedLink { get; set; }

        /// <summary>
        /// By setting this value to `null`, the shared link
        /// is removed from the file.
        /// </summary>
        [JsonPropertyName("shared_link")]
        public RemoveSharedLinkFromFileRequestBodySharedLinkField? SharedLink { get => _sharedLink; init { _sharedLink = value; _isSharedLinkSet = true; } }

        public RemoveSharedLinkFromFileRequestBody() {
            
        }
    }
}