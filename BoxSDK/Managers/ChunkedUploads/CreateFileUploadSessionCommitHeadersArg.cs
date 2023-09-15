using System.Text.Json.Serialization;
using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class CreateFileUploadSessionCommitHeadersArg {
        /// <summary>
        /// The [RFC3230][1] message digest of the whole file.
        /// 
        /// Only SHA1 is supported. The SHA1 digest must be Base64
        /// encoded. The format of this header is as
        /// `sha=BASE64_ENCODED_DIGEST`.
        /// 
        /// [1]: https://tools.ietf.org/html/rfc3230
        /// </summary>
        public string Digest { get; set; }

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
        /// Ensures an item is only returned if it has changed.
        /// 
        /// Pass in the item's last observed `etag` value
        /// into this header and the endpoint will fail
        /// with a `304 Not Modified` if the item has not
        /// changed since.
        /// </summary>
        public string? IfNoneMatch { get; set; } = default;

        /// <summary>
        /// Extra headers that will be included in the HTTP request.
        /// </summary>
        public Dictionary<string, string?>? ExtraHeaders { get; set; } = new Dictionary<string, string?>() {  };

        public CreateFileUploadSessionCommitHeadersArg(string digest) {
            Digest = digest;
        }
    }
}