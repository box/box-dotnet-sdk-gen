using Unions;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class GetFolderByIdHeadersArg {
        /// <summary>
        /// Ensures an item is only returned if it has changed.
        /// 
        /// Pass in the item's last observed `etag` value
        /// into this header and the endpoint will fail
        /// with a `304 Not Modified` if the item has not
        /// changed since.
        /// </summary>
        public string? IfNoneMatch { get; set; } = default;

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
        public string? Boxapi { get; set; } = default;

        /// <summary>
        /// Extra headers that will be included in the HTTP request.
        /// </summary>
        public Dictionary<string, string?>? ExtraHeaders { get; set; } = new Dictionary<string, string?>() {  };

        public GetFolderByIdHeadersArg() {
            
        }
    }
}