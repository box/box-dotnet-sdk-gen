using System.IO;
using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text.Json.Serialization;
using System;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class UpdateFileByIdHeadersArg {
        public string IfMatch { get; }

        public Dictionary<string, string> ExtraHeaders { get; }

        public UpdateFileByIdHeadersArg(string ifMatch, Dictionary<string, string> extraHeaders) {
            IfMatch = ifMatch;
            ExtraHeaders = extraHeaders;
        }
    }
}