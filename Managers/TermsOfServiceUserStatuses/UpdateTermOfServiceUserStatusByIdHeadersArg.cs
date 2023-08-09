using System.IO;
using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text.Json.Serialization;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class UpdateTermOfServiceUserStatusByIdHeadersArg {
        public Dictionary<string, string> ExtraHeaders { get; }

        public UpdateTermOfServiceUserStatusByIdHeadersArg(Dictionary<string, string> extraHeaders) {
            ExtraHeaders = extraHeaders;
        }
    }
}