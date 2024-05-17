using Unions;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Box.Sdk.Gen.Schemas;
using Box.Sdk.Gen;

namespace Box.Sdk.Gen.Managers {
    public class GetFolderItemsHeaders {
        /// <summary>
        /// The URL, and optional password, for the shared link of this item.
        /// 
        /// This header can be used to access items that have not been
        /// explicitly shared with a user.
        /// 
        /// Use the format `shared_link=[link]` or if a password is required then
        /// use `shared_link=[link]&shared_link_password=[password]`.
        /// 
        /// This header can be used on the file or folder shared, as well as on any files
        /// or folders nested within the item.
        /// </summary>
        public string? Boxapi { get; init; }

        /// <summary>
        /// Extra headers that will be included in the HTTP request.
        /// </summary>
        public Dictionary<string, string?> ExtraHeaders { get; init; }

        public GetFolderItemsHeaders(Dictionary<string, string?> extraHeaders = default) {
            ExtraHeaders = extraHeaders ?? new Dictionary<string, string?>() {  };
        }
    }
}