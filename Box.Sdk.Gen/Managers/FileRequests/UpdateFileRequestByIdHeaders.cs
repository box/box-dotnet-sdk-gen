using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Box.Sdk.Gen.Schemas;
using Box.Sdk.Gen;

namespace Box.Sdk.Gen.Managers {
    public class UpdateFileRequestByIdHeaders {
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
        /// Extra headers that will be included in the HTTP request.
        /// </summary>
        public Dictionary<string, string?> ExtraHeaders { get; set; }

        public UpdateFileRequestByIdHeaders(Dictionary<string, string?> extraHeaders = default) {
            ExtraHeaders = extraHeaders ?? new Dictionary<string, string?>() {  };
        }
    }
}