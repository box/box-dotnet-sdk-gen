using System.IO;
using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class GetFileVersionLegalHoldsHeadersArg {
        public Dictionary<string, string> ExtraHeaders { get; }

        public GetFileVersionLegalHoldsHeadersArg(Dictionary<string, string> extraHeaders) {
            ExtraHeaders = extraHeaders;
        }
    }
}