using Box.Sdk.Gen;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System;
using Box.Sdk.Gen.Internal;
using Box.Sdk.Gen.Schemas;

namespace Box.Sdk.Gen.Managers {
    public class GetEventsHeaders {
        /// <summary>
        /// Extra headers that will be included in the HTTP request.
        /// </summary>
        public Dictionary<string, string?> ExtraHeaders { get; }

        public GetEventsHeaders(Dictionary<string, string?>? extraHeaders = default) {
            ExtraHeaders = extraHeaders ?? new Dictionary<string, string?>() {  };
        }
    }
}