using Unions;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Box.Sdk.Gen.Schemas;
using Box.Sdk.Gen;

namespace Box.Sdk.Gen.Managers {
    public class UpdateLegalHoldPolicyByIdHeaders {
        /// <summary>
        /// Extra headers that will be included in the HTTP request.
        /// </summary>
        public Dictionary<string, string?> ExtraHeaders { get; init; }

        public UpdateLegalHoldPolicyByIdHeaders(Dictionary<string, string?> extraHeaders = default) {
            ExtraHeaders = extraHeaders ?? new Dictionary<string, string?>() {  };
        }
    }
}