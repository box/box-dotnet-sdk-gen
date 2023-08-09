using System.IO;
using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class GetSharedItemFoldersHeadersArg {
        public string IfNoneMatch { get; }

        public string Boxapi { get; }

        public Dictionary<string, string> ExtraHeaders { get; }

        public GetSharedItemFoldersHeadersArg(string ifNoneMatch, string boxapi, Dictionary<string, string> extraHeaders) {
            IfNoneMatch = ifNoneMatch;
            Boxapi = boxapi;
            ExtraHeaders = extraHeaders;
        }
    }
}