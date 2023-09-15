using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class GetSharedItemFoldersHeadersArg {
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
        /// A header containing the shared link and optional password for the
        /// shared link.
        /// 
        /// The format for this header is as follows.
        /// 
        /// `shared_link=[link]&shared_link_password=[password]`
        /// </summary>
        public string Boxapi { get; set; }

        /// <summary>
        /// Extra headers that will be included in the HTTP request.
        /// </summary>
        public Dictionary<string, string?>? ExtraHeaders { get; set; } = new Dictionary<string, string?>() {  };

        public GetSharedItemFoldersHeadersArg(string boxapi) {
            Boxapi = boxapi;
        }
    }
}