using System.IO;
using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class GetFolderByIdHeadersArg {
        public string IfNoneMatch { get; }

        public string Boxapi { get; }

        public Dictionary<string, string> ExtraHeaders { get; }

        public GetFolderByIdHeadersArg(string ifNoneMatch, string boxapi, Dictionary<string, string> extraHeaders) {
            IfNoneMatch = ifNoneMatch;
            Boxapi = boxapi;
            ExtraHeaders = extraHeaders;
        }
    }
}