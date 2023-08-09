using System.IO;
using Unions;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class UploadFileHeadersArg {
        public string ContentMd5 { get; }

        public Dictionary<string, string> ExtraHeaders { get; }

        public UploadFileHeadersArg(string contentMd5, Dictionary<string, string> extraHeaders) {
            ContentMd5 = contentMd5;
            ExtraHeaders = extraHeaders;
        }
    }
}