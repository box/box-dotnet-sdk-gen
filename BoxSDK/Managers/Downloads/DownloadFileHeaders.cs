using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class DownloadFileHeaders {
        /// <summary>
        /// The byte range of the content to download.
        /// 
        /// The format `bytes={start_byte}-{end_byte}` can be used to specify
        /// what section of the file to download.
        /// </summary>
        public string? Range { get; set; } = default;

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
        public Dictionary<string, string?> ExtraHeaders { get; set; } = new Dictionary<string, string?>() {  };

        public DownloadFileHeaders() {
            
        }
    }
}