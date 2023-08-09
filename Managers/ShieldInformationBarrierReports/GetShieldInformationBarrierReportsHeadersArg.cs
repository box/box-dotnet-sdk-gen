using System.IO;
using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class GetShieldInformationBarrierReportsHeadersArg {
        public Dictionary<string, string> ExtraHeaders { get; }

        public GetShieldInformationBarrierReportsHeadersArg(Dictionary<string, string> extraHeaders) {
            ExtraHeaders = extraHeaders;
        }
    }
}