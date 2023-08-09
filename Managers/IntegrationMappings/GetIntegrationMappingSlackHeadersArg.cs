using System.IO;
using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class GetIntegrationMappingSlackHeadersArg {
        public Dictionary<string, string> ExtraHeaders { get; }

        public GetIntegrationMappingSlackHeadersArg(Dictionary<string, string> extraHeaders) {
            ExtraHeaders = extraHeaders;
        }
    }
}