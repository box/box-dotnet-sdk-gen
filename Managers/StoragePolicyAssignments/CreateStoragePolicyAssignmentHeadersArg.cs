using System.IO;
using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text.Json.Serialization;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class CreateStoragePolicyAssignmentHeadersArg {
        public Dictionary<string, string> ExtraHeaders { get; }

        public CreateStoragePolicyAssignmentHeadersArg(Dictionary<string, string> extraHeaders) {
            ExtraHeaders = extraHeaders;
        }
    }
}