using System.IO;
using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class GetLegalHoldPolicyAssignmentsHeadersArg {
        public Dictionary<string, string> ExtraHeaders { get; }

        public GetLegalHoldPolicyAssignmentsHeadersArg(Dictionary<string, string> extraHeaders) {
            ExtraHeaders = extraHeaders;
        }
    }
}