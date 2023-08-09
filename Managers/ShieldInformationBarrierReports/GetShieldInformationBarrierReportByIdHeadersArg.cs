using System.IO;
using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class GetShieldInformationBarrierReportByIdHeadersArg {
        public Dictionary<string, string> ExtraHeaders { get; }

        public GetShieldInformationBarrierReportByIdHeadersArg(Dictionary<string, string> extraHeaders) {
            ExtraHeaders = extraHeaders;
        }
    }
}