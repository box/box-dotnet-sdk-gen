using System.IO;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Unions;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class CreateGroupTerminateSessionHeadersArg {
        public Dictionary<string, string> ExtraHeaders { get; }

        public CreateGroupTerminateSessionHeadersArg(Dictionary<string, string> extraHeaders) {
            ExtraHeaders = extraHeaders;
        }
    }
}