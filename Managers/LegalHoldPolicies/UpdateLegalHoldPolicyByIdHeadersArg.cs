using System.IO;
using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text.Json.Serialization;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class UpdateLegalHoldPolicyByIdHeadersArg {
        public Dictionary<string, string> ExtraHeaders { get; }

        public UpdateLegalHoldPolicyByIdHeadersArg(Dictionary<string, string> extraHeaders) {
            ExtraHeaders = extraHeaders;
        }
    }
}