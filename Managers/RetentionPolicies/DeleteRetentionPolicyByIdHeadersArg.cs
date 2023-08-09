using System.IO;
using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System;
using System.Text.Json.Serialization;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class DeleteRetentionPolicyByIdHeadersArg {
        public Dictionary<string, string> ExtraHeaders { get; }

        public DeleteRetentionPolicyByIdHeadersArg(Dictionary<string, string> extraHeaders) {
            ExtraHeaders = extraHeaders;
        }
    }
}