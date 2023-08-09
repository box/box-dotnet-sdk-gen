using System.IO;
using System.Text.Json.Serialization;
using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class DeleteFileUploadSessionByIdHeadersArg {
        public Dictionary<string, string> ExtraHeaders { get; }

        public DeleteFileUploadSessionByIdHeadersArg(Dictionary<string, string> extraHeaders) {
            ExtraHeaders = extraHeaders;
        }
    }
}