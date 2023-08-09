using System.IO;
using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class GetFileByIdHeadersArg {
        public string IfNoneMatch { get; }

        public string Boxapi { get; }

        public string XRepHints { get; }

        public Dictionary<string, string> ExtraHeaders { get; }

        public GetFileByIdHeadersArg(string ifNoneMatch, string boxapi, string xRepHints, Dictionary<string, string> extraHeaders) {
            IfNoneMatch = ifNoneMatch;
            Boxapi = boxapi;
            XRepHints = xRepHints;
            ExtraHeaders = extraHeaders;
        }
    }
}