using System.IO;
using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class GetFileVersionRetentionByIdHeadersArg {
        public Dictionary<string, string> ExtraHeaders { get; }

        public GetFileVersionRetentionByIdHeadersArg(Dictionary<string, string> extraHeaders) {
            ExtraHeaders = extraHeaders;
        }
    }
}