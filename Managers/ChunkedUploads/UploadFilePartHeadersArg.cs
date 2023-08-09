using System.IO;
using System.Text.Json.Serialization;
using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class UploadFilePartHeadersArg {
        public string Digest { get; }

        public string ContentRange { get; }

        public Dictionary<string, string> ExtraHeaders { get; }

        public UploadFilePartHeadersArg(string digest, string contentRange, Dictionary<string, string> extraHeaders) {
            Digest = digest;
            ContentRange = contentRange;
            ExtraHeaders = extraHeaders;
        }
    }
}