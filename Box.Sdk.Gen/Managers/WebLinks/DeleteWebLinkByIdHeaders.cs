using System.Text.Json.Serialization;
using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Box.Sdk.Gen.Schemas;
using Box.Sdk.Gen;

namespace Box.Sdk.Gen.Managers {
    public class DeleteWebLinkByIdHeaders {
        /// <summary>
        /// Extra headers that will be included in the HTTP request.
        /// </summary>
        public Dictionary<string, string?> ExtraHeaders { get; init; }

        public DeleteWebLinkByIdHeaders(Dictionary<string, string?> extraHeaders = default) {
            ExtraHeaders = extraHeaders ?? new Dictionary<string, string?>() {  };
        }
    }
}