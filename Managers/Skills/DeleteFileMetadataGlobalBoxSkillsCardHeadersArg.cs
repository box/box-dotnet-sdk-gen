using System.IO;
using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class DeleteFileMetadataGlobalBoxSkillsCardHeadersArg {
        public Dictionary<string, string> ExtraHeaders { get; }

        public DeleteFileMetadataGlobalBoxSkillsCardHeadersArg(Dictionary<string, string> extraHeaders) {
            ExtraHeaders = extraHeaders;
        }
    }
}