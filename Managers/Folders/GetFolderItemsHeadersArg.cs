using System.IO;
using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text.Json.Serialization;
using System;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class GetFolderItemsHeadersArg {
        public string Boxapi { get; }

        public Dictionary<string, string> ExtraHeaders { get; }

        public GetFolderItemsHeadersArg(string boxapi, Dictionary<string, string> extraHeaders) {
            Boxapi = boxapi;
            ExtraHeaders = extraHeaders;
        }
    }
}