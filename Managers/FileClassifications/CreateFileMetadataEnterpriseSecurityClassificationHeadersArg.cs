using System.IO;
using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text.Json.Serialization;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class CreateFileMetadataEnterpriseSecurityClassificationHeadersArg {
        public Dictionary<string, string> ExtraHeaders { get; }

        public CreateFileMetadataEnterpriseSecurityClassificationHeadersArg(Dictionary<string, string> extraHeaders) {
            ExtraHeaders = extraHeaders;
        }
    }
}