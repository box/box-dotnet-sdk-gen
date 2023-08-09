using System.IO;
using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text.Json.Serialization;
using System;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class UpdateMetadataTemplateEnterpriseSecurityClassificationSchemaDeleteHeadersArg {
        public Dictionary<string, string> ExtraHeaders { get; }

        public UpdateMetadataTemplateEnterpriseSecurityClassificationSchemaDeleteHeadersArg(Dictionary<string, string> extraHeaders) {
            ExtraHeaders = extraHeaders;
        }
    }
}