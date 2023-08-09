using System.IO;
using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class GetLegalHoldPoliciesHeadersArg {
        public Dictionary<string, string> ExtraHeaders { get; }

        public GetLegalHoldPoliciesHeadersArg(Dictionary<string, string> extraHeaders) {
            ExtraHeaders = extraHeaders;
        }
    }
}