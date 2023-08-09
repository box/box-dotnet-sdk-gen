using System.IO;
using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System;
using System.Text.Json.Serialization;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class DeleteMetadataTemplateSchemaHeadersArg {
        public Dictionary<string, string> ExtraHeaders { get; }

        public DeleteMetadataTemplateSchemaHeadersArg(Dictionary<string, string> extraHeaders) {
            ExtraHeaders = extraHeaders;
        }
    }
}