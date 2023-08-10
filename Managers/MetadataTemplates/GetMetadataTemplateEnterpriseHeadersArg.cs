using System.IO;
using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System;
using System.Text.Json.Serialization;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class GetMetadataTemplateEnterpriseHeadersArg {
        public Dictionary<string, string> ExtraHeaders { get; }

        public GetMetadataTemplateEnterpriseHeadersArg(Dictionary<string, string> extraHeaders) {
            ExtraHeaders = extraHeaders;
        }
    }
}