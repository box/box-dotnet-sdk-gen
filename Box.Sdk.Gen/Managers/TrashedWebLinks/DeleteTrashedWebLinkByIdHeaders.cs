using Box.Sdk.Gen;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using Box.Sdk.Gen.Schemas;
using Box.Sdk.Gen.Internal;

namespace Box.Sdk.Gen.Managers {
    public class DeleteTrashedWebLinkByIdHeaders {
        /// <summary>
        /// Extra headers that will be included in the HTTP request.
        /// </summary>
        public Dictionary<string, string?> ExtraHeaders { get; }

        public DeleteTrashedWebLinkByIdHeaders(Dictionary<string, string?>? extraHeaders = default) {
            ExtraHeaders = extraHeaders ?? new Dictionary<string, string?>() {  };
        }
    }
}