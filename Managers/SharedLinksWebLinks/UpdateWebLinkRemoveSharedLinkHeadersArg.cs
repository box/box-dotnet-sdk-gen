using System.IO;
using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text.Json.Serialization;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class UpdateWebLinkRemoveSharedLinkHeadersArg {
        public Dictionary<string, string> ExtraHeaders { get; }

        public UpdateWebLinkRemoveSharedLinkHeadersArg(Dictionary<string, string> extraHeaders) {
            ExtraHeaders = extraHeaders;
        }
    }
}