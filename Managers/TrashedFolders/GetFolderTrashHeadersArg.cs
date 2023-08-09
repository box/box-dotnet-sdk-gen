using System.IO;
using Unions;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class GetFolderTrashHeadersArg {
        public Dictionary<string, string> ExtraHeaders { get; }

        public GetFolderTrashHeadersArg(Dictionary<string, string> extraHeaders) {
            ExtraHeaders = extraHeaders;
        }
    }
}