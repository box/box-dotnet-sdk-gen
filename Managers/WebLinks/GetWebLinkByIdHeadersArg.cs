using System.IO;
using System.Text.Json.Serialization;
using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class GetWebLinkByIdHeadersArg {
        public string Boxapi { get; }

        public Dictionary<string, string> ExtraHeaders { get; }

        public GetWebLinkByIdHeadersArg(string boxapi, Dictionary<string, string> extraHeaders) {
            Boxapi = boxapi;
            ExtraHeaders = extraHeaders;
        }
    }
}