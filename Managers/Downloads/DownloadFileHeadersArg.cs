using System.IO;
using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class DownloadFileHeadersArg {
        public string Range { get; }

        public string Boxapi { get; }

        public Dictionary<string, string> ExtraHeaders { get; }

        public DownloadFileHeadersArg(string range, string boxapi, Dictionary<string, string> extraHeaders) {
            Range = range;
            Boxapi = boxapi;
            ExtraHeaders = extraHeaders;
        }
    }
}