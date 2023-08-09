using System.IO;
using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class GetUserEmailAliasesHeadersArg {
        public Dictionary<string, string> ExtraHeaders { get; }

        public GetUserEmailAliasesHeadersArg(Dictionary<string, string> extraHeaders) {
            ExtraHeaders = extraHeaders;
        }
    }
}