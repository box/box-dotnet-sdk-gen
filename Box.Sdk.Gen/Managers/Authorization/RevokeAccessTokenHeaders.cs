using Unions;
using Box.Sdk.Gen;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Box.Sdk.Gen.Schemas;

namespace Box.Sdk.Gen.Managers {
    public class RevokeAccessTokenHeaders {
        /// <summary>
        /// Extra headers that will be included in the HTTP request.
        /// </summary>
        public Dictionary<string, string?> ExtraHeaders { get; init; }

        public RevokeAccessTokenHeaders(Dictionary<string, string?> extraHeaders = default) {
            ExtraHeaders = extraHeaders ?? new Dictionary<string, string?>() {  };
        }
    }
}