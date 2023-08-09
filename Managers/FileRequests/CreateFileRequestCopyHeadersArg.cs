using System.IO;
using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class CreateFileRequestCopyHeadersArg {
        public Dictionary<string, string> ExtraHeaders { get; }

        public CreateFileRequestCopyHeadersArg(Dictionary<string, string> extraHeaders) {
            ExtraHeaders = extraHeaders;
        }
    }
}