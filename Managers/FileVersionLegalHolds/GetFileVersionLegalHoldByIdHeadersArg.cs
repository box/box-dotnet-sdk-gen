using System.IO;
using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class GetFileVersionLegalHoldByIdHeadersArg {
        public Dictionary<string, string> ExtraHeaders { get; }

        public GetFileVersionLegalHoldByIdHeadersArg(Dictionary<string, string> extraHeaders) {
            ExtraHeaders = extraHeaders;
        }
    }
}