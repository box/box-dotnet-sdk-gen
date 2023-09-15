using Unions;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class UploadFileVersionHeadersArg {
        /// <summary>
        /// Ensures this item hasn't recently changed before
        /// making changes.
        /// 
        /// Pass in the item's last observed `etag` value
        /// into this header and the endpoint will fail
        /// with a `412 Precondition Failed` if it
        /// has changed since.
        /// </summary>
        public string? IfMatch { get; set; } = default;

        /// <summary>
        /// An optional header containing the SHA1 hash of the file to
        /// ensure that the file was not corrupted in transit.
        /// </summary>
        public string? ContentMd5 { get; set; } = default;

        /// <summary>
        /// Extra headers that will be included in the HTTP request.
        /// </summary>
        public Dictionary<string, string?>? ExtraHeaders { get; set; } = new Dictionary<string, string?>() {  };

        public UploadFileVersionHeadersArg() {
            
        }
    }
}