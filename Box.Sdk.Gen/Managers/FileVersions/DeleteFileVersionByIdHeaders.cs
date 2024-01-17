using Unions;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Box.Sdk.Gen.Schemas;
using Box.Sdk.Gen;

namespace Box.Sdk.Gen.Managers {
    public class DeleteFileVersionByIdHeaders {
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
        public Dictionary<string, string?> ExtraHeaders { get; set; } = new Dictionary<string, string?>() {  };

        public DeleteFileVersionByIdHeaders() {
            
        }
    }
}