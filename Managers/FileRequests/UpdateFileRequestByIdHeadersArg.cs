using System.IO;
using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class UpdateFileRequestByIdHeadersArg {
        public string IfMatch { get; }

        public Dictionary<string, string> ExtraHeaders { get; }

        public UpdateFileRequestByIdHeadersArg(string ifMatch, Dictionary<string, string> extraHeaders) {
            IfMatch = ifMatch;
            ExtraHeaders = extraHeaders;
        }
    }
}