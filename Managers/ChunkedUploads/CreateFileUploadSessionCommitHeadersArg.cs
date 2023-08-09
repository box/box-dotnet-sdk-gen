using System.IO;
using System.Text.Json.Serialization;
using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class CreateFileUploadSessionCommitHeadersArg {
        public string Digest { get; }

        public string IfMatch { get; }

        public string IfNoneMatch { get; }

        public Dictionary<string, string> ExtraHeaders { get; }

        public CreateFileUploadSessionCommitHeadersArg(string digest, string ifMatch, string ifNoneMatch, Dictionary<string, string> extraHeaders) {
            Digest = digest;
            IfMatch = ifMatch;
            IfNoneMatch = ifNoneMatch;
            ExtraHeaders = extraHeaders;
        }
    }
}