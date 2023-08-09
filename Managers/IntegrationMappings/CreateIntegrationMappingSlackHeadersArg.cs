using System.IO;
using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class CreateIntegrationMappingSlackHeadersArg {
        public Dictionary<string, string> ExtraHeaders { get; }

        public CreateIntegrationMappingSlackHeadersArg(Dictionary<string, string> extraHeaders) {
            ExtraHeaders = extraHeaders;
        }
    }
}