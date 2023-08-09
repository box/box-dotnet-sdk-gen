using System.IO;
using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text.Json.Serialization;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class GetStoragePolicyAssignmentByIdHeadersArg {
        public Dictionary<string, string> ExtraHeaders { get; }

        public GetStoragePolicyAssignmentByIdHeadersArg(Dictionary<string, string> extraHeaders) {
            ExtraHeaders = extraHeaders;
        }
    }
}