using System.IO;
using Unions;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class DeleteWebLinkTrashHeadersArg {
        public Dictionary<string, string> ExtraHeaders { get; }

        public DeleteWebLinkTrashHeadersArg(Dictionary<string, string> extraHeaders) {
            ExtraHeaders = extraHeaders;
        }
    }
}