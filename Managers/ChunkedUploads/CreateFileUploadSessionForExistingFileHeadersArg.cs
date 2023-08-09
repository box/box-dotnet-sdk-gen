using System.IO;
using System.Text.Json.Serialization;
using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class CreateFileUploadSessionForExistingFileHeadersArg {
        public Dictionary<string, string> ExtraHeaders { get; }

        public CreateFileUploadSessionForExistingFileHeadersArg(Dictionary<string, string> extraHeaders) {
            ExtraHeaders = extraHeaders;
        }
    }
}