using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text.Json.Serialization;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class UpdateWebLinkAddSharedLinkRequestBodyArg {
        /// <summary>
        /// The settings for the shared link to create on the web link.
        /// 
        /// Use an empty object (`{}`) to use the default settings for shared
        /// links.
        /// </summary>
        [JsonPropertyName("shared_link")]
        public UpdateWebLinkAddSharedLinkRequestBodyArgSharedLinkField? SharedLink { get; set; } = default;

        public UpdateWebLinkAddSharedLinkRequestBodyArg() {
            
        }
    }
}